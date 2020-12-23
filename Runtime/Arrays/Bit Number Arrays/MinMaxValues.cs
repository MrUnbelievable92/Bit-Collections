namespace BitCollections
{
    public readonly ref struct UInt2    {    public const byte   MinValue = 0;               public const byte   MaxValue = 3;              }
    public readonly ref struct UInt3    {    public const byte   MinValue = 0;               public const byte   MaxValue = 7;              }
    public readonly ref struct UInt4    {    public const byte   MinValue = 0;               public const byte   MaxValue = 15;             }
    public readonly ref struct UInt5    {    public const byte   MinValue = 0;               public const byte   MaxValue = 31;             }
    public readonly ref struct UInt6    {    public const byte   MinValue = 0;               public const byte   MaxValue = 63;             }
    public readonly ref struct UInt7    {    public const byte   MinValue = 0;               public const byte   MaxValue = 127;            }
    public readonly ref struct UInt10   {    public const ushort MinValue = 0;               public const ushort MaxValue = 1_023;          }
    public readonly ref struct UInt12   {    public const ushort MinValue = 0;               public const ushort MaxValue = 4_095;          }
    public readonly ref struct UInt14   {    public const ushort MinValue = 0;               public const ushort MaxValue = 16_383;         }
    public readonly ref struct UInt20   {    public const uint   MinValue = 0;               public const uint   MaxValue = 1_048_575;      }
    public readonly ref struct UInt28   {    public const uint   MinValue = 0;               public const uint   MaxValue = 268_435_455;    }

    public readonly ref struct Int2     {    public const sbyte  MinValue = -2;              public const sbyte  MaxValue = 1;              }
    public readonly ref struct Int3     {    public const sbyte  MinValue = -4;              public const sbyte  MaxValue = 3;              }
    public readonly ref struct Int4     {    public const sbyte  MinValue = -8;              public const sbyte  MaxValue = 7;              }
    public readonly ref struct Int5     {    public const sbyte  MinValue = -16;             public const sbyte  MaxValue = 15;             }
    public readonly ref struct Int6     {    public const sbyte  MinValue = -32;             public const sbyte  MaxValue = 31;             }
    public readonly ref struct Int7     {    public const sbyte  MinValue = -64;             public const sbyte  MaxValue = 63;             }
    public readonly ref struct Int10    {    public const short  MinValue = -512;            public const short  MaxValue = 511;            }
    public readonly ref struct Int12    {    public const short  MinValue = -2_048;          public const short  MaxValue = 2_047;          }
    public readonly ref struct Int14    {    public const short  MinValue = -8_192;          public const short  MaxValue = 8_191;          }
    public readonly ref struct Int20    {    public const int    MinValue = -524_288;        public const int    MaxValue = 524_287;        }
    public readonly ref struct Int28    {    public const int    MinValue = -134_217_728;    public const int    MaxValue = 134_217_727;    }
}