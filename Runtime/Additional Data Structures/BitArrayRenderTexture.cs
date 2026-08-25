using System;
using System.Runtime.InteropServices;
using UnityEngine;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using DevTools;

namespace BitCollections
{
    [StructLayout(LayoutKind.Auto, Pack = 1)]
    unsafe public class BitArrayRenderTexture : IDisposable
    {
        public enum OptimizeFor : byte
        {
            UploadSpeed = 0,
            VRAM = 1
        }

        private static readonly ComputeShader BITARRAY_TO_TEXTURE_COMPUTE;
        private static readonly int KERNEL;
        private static readonly int WIDTH_ID;
        private static readonly int HEIGHT_ID;
        private static readonly int TRUE_COLOR_ID;
        private static readonly int FALSE_COLOR_ID;
        private static readonly int BITBUFFER_ID;
        private static readonly int RENDERTEXTURE_ID;
        
        public RenderTexture RenderTexture { get; private set; }

        private Color32 _TrueColor = Color.white;
        private Color32 _FalseColor = Color.black;
        public Color32 TrueColor
        {
            get => _TrueColor;
            set
            {
                _TrueColor = value;
                BitArrayToTextureComputeInstance.SetVector(TRUE_COLOR_ID, (Color)_TrueColor);
            }
        }
        public Color32 FalseColor
        {
            get => _FalseColor;
            set
            {
                _FalseColor = value;
                BitArrayToTextureComputeInstance.SetVector(FALSE_COLOR_ID, (Color)_FalseColor);
            }
        }
        
        private ushort width;
        private ushort height;
        public int Width
        {
            get => width;
            set => width = (ushort)value;
        }
        public int Height
        {
            get => height;
            set => height = (ushort)value;
        }

        private readonly ushort ThreadGroupsX;

        private readonly ComputeShader BitArrayToTextureComputeInstance;
        private ComputeBuffer BitBuffer;

        private readonly NativeArray<uint> BitArrayAlias;
        private readonly OptimizeFor OptimizationScheme;
    

        static BitArrayRenderTexture()
        {
            BITARRAY_TO_TEXTURE_COMPUTE = Resources.Load<ComputeShader>("BitArrayToTexture");
            KERNEL = BITARRAY_TO_TEXTURE_COMPUTE.FindKernel("k");
            WIDTH_ID = Shader.PropertyToID("w");
            HEIGHT_ID = Shader.PropertyToID("h");
            TRUE_COLOR_ID = Shader.PropertyToID("t");
            FALSE_COLOR_ID = Shader.PropertyToID("f");
            BITBUFFER_ID = Shader.PropertyToID("b");
            RENDERTEXTURE_ID = Shader.PropertyToID("r");
        }


        public BitArrayRenderTexture(int width, int height, NativeBitArray array, RenderTextureFormat format, OptimizeFor optimizationScheme = OptimizeFor.UploadSpeed)
        {
Assert.AreEqual(array.Length, width * height);

            this.width = (ushort)width;
            this.height = (ushort)height;
            ThreadGroupsX = (ushort)(((((uint)width * (uint)height + 31u) / 32u) + 63u) / 64u);
            OptimizationScheme = optimizationScheme;
            
            RenderTexture = new RenderTexture(width, height, 0, format);
            RenderTexture.enableRandomWrite = true;
            RenderTexture.Create();

            BitArrayAlias = NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<uint>(array.GetUnsafeReadOnlyPtr(), (int)((uint)(array.Length + 31) / 32u), Allocator.None);
#if ENABLE_UNITY_COLLECTIONS_CHECKS        
NativeArrayUnsafeUtility.SetAtomicSafetyHandle(ref BitArrayAlias, array.GetAtomicSafetyHandle());
#endif
            BitArrayToTextureComputeInstance = UnityEngine.Object.Instantiate(BITARRAY_TO_TEXTURE_COMPUTE);
            BitArrayToTextureComputeInstance.SetTexture(KERNEL, RENDERTEXTURE_ID, RenderTexture);
            BitArrayToTextureComputeInstance.SetInt(WIDTH_ID, width);
            BitArrayToTextureComputeInstance.SetInt(HEIGHT_ID, height);

            if (OptimizationScheme == OptimizeFor.UploadSpeed)
            {
                InitBitBuffer();
            }
        }
        
        private void InitBitBuffer()
        {
            BitBuffer = new ComputeBuffer((int)((uint)(width * height + 31) / 32u), sizeof(uint), ComputeBufferType.Default);
            BitArrayToTextureComputeInstance.SetBuffer(KERNEL, BITBUFFER_ID, BitBuffer);
        }

        public void Apply()
        {
            if (OptimizationScheme == OptimizeFor.VRAM)
            {
                InitBitBuffer();
            }

            BitBuffer.SetData(BitArrayAlias);
            BitArrayToTextureComputeInstance.Dispatch(KERNEL, ThreadGroupsX, 1, 1);
            
            if (OptimizationScheme == OptimizeFor.VRAM)
            {
                BitBuffer.Dispose();
                BitBuffer = null;
            }
        }
    
        public void Dispose()
        {
            BitBuffer?.Dispose();
            RenderTexture.Release();
        }
    }
}