using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Instructions
{
    public static Dictionary<string, IInstructionable<string>> instructions = new Dictionary<string, IInstructionable<string>>();
    public Instructions()
    {
        instructions["ST"] = new ST();
        instructions["LD"] = new LD();
    }
}
