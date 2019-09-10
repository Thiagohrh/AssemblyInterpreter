using System.Collections.Generic;
public class Registers
{
    public static Dictionary<string, int> registry = new Dictionary<string, int>();
    public Registers()
    {
        registry["AC"] = 0;
        registry["PC"] = 0;
        registry["N"] = 0;
        registry["Z"] = 0;
    }
}
