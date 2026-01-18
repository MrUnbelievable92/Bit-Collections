using static MaxMath.maxmath;

namespace BitCollections
{
    internal partial class CodeGen
    {
        private static string BitIntBase(bool signed, int bits)
        {
            string result = string.Empty;
            string ceiltype;
            string instance;
            long minValue;
            long maxValue;

            if (signed)
            {
                ceiltype = bits <= 8 ? "sbyte" : bits <= 16 ? "short" : bits <= 32 ? "int" : "long";
                instance = $"Int{bits}";

                minValue = -(1L << (bits - 1));
                maxValue = (1L << (bits - 1)) - 1;
            }
            else
            {
                ceiltype = bits <= 8 ? "byte" : bits <= 16 ? "ushort" : bits <= 32 ? "uint" : "ulong";
                instance = bits == 1 ? "Bit" : $"UInt{bits}";

                minValue = 0;
                maxValue = (1L << bits) - 1;
            }

            result += $"\tpublic readonly struct {instance} : BitInt\n";
            result += "\t{\n";
            result += $"\t\tpublic const {ceiltype} MinValue = {minValue};\n";
            if (signed)
            {
                result += $"\t\tpublic const {ceiltype} MaxValue =  {maxValue};\n";
            }
            else
            {
                result += $"\t\tpublic const {ceiltype} MaxValue = {maxValue};\n";
            }
            result += "\n";
            result += $"\t\tpublic bool IsSigned => {signed.ToString().ToLower()};\n";
            result += $"\t\tpublic byte Bits => {bits};\n";
            result += $"\t\tpublic byte MinEvenBytes => {lcm(bits, 8) / 8};\n";
            result += $"\t\tpublic long MinValueAsLong => (long)MinValue;\n";
            result += $"\t\tpublic long MaxValueAsLong => (long)MaxValue;\n";
            result += "\t}\n";
            result += "\n";

            return result;
        }

        internal static string BitInts()
        {
            string result = string.Empty;

            for (int i = 1; i < 64; i++)
            {
                result += BitIntBase(false, i);

                if (i == 1)
                {
                    result += "\n";
                }
            }

            result += "\n";

            for (int i = 2; i < 64; i++)
            {
                result += BitIntBase(true, i);
            }

            return result;
        }
    }
}
