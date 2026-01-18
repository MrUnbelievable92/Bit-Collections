namespace BitCollections
{
    internal static partial class CodeGen
    {
        internal static string BitFieldHelper()
        {
            string result = string.Empty;
            for (int i = 0; i < 62; i++)
            {
                result += "\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n";
                result += "\t\tinternal static int Index<";
                for(int j = 0; j <= i; j++)
                {
                    result += $"T{j}";
                    if (j != i)
                    {
                        result += ", ";
                    }
                    else
                    {
                        result += ">()\n";
                    }
                }
                for(int j = 0; j <= i; j++)
                {
                    result += $"\t\t\twhere T{j} : BitInt\n";
                }
                result += "\t\t{\n";
                result += "\t\t\treturn ";
                for(int j = 0; j <= i; j++)
                {
                    result += $"default(T{j}).Bits";
                    if (j != i)
                    {
                        result += " + ";
                    }
                    else
                    {
                        result += ";\n";
                    }
                }
                result += "\t\t}\n";
                result += "\n";
            }

            return result;
        }
    }
}
