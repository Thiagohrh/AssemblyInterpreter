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
        instructions["ADD"] = new ADD();
        instructions["SUB"] = new SUB();
        instructions["JMP"] = new JMP();
        instructions["JN"] = new JN();
        instructions["JP"] = new JP();
        instructions["JZ"] = new JZ();
        instructions["JNZ"] = new JNZ();
        instructions["HALT"] = new HALT();
    }
}
