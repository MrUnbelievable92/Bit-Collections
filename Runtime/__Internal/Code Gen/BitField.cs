namespace BitCollections
{
    unsafe internal static partial class CodeGen
    {
        internal static string BitFieldBase(int numParams, string type, string bits)
        {
            static string AppendTParams(int numParams)
            {
                string result = "<";
                for (int i = 0; i < numParams; i++)
                {
                    result += $"T{i}";
                    if (i + 1 != numParams)
                    {
                        result += ", ";
                    }
                    else
                    {
                        result += ">";
                    }
                }

                return result;
            }


            string fieldType = int.Parse(bits) > 32 ? "long" : "int";
            string cast = int.Parse(bits) > 32 ? "" : "(int)";

            string result = $"\t[Serializable]\n";
            result += $"\tpublic struct BitField{bits}{AppendTParams(numParams)}\n";
            for (int i = 0; i < numParams; i++)
            {
                result += $"\t\twhere T{i} : BitInt\n";
            }
            result += "\t{\n";
            result += $"\t\tprivate {type} Bits;\n";
            result += "\n";

            for (int i = 0; i < numParams; i++)
            {
                string idx = ((i == 0) ? "0" : $"Index{AppendTParams(i) + "()"}");

                result += $"\t\tpublic {fieldType} Field{i}\n";
                result += "\t\t{\n";
                result += $"\t\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get => {cast}Get<T{i}>(Bits, {idx}, {bits});\n";
                result += $"\t\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)] set => Bits = ({type})Set<T{i}>(Bits, value, {idx}, {bits});\n";
                result += "\t\t}\n";
            }
            result += "\t}\n";

            return result;
        }

        internal static string BitField<T>()
            where T : unmanaged
        {
            string gen = string.Empty;

            int bits = 8 * sizeof(T);

            for (int i = 2; i < bits; i++)
            {
                gen += BitFieldBase(i, typeof(T).Name, bits.ToString());
                gen += "\n";
            }

            return gen;
        }
    }
}
