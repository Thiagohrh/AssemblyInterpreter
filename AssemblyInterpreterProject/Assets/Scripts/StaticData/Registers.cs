using System.Collections.Generic;
public class Registers
{
    public static Dictionary<string, int> registry = new Dictionary<string, int>();
    public static class DrawCursor
    {
        public static int X = 0;
        public static int Y = 0;
    }
    public Registers()
    {
        SetupBasicRegisters();
    }

    public static void ClearnRegisters()
    {
        registry = new Dictionary<string, int>();
        SetupBasicRegisters();
    }

    static private void SetupBasicRegisters()
    {
        registry["AC"] = 0;
        registry["AC2"] = 0;
        registry["AC3"] = 0;
        registry["PC"] = 0;
        registry["N"] = 0;
        registry["Z"] = 0;
    }
}
