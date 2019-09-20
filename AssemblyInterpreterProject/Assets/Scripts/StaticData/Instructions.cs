using System.Collections.Generic;
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
        //Second architecture functions.
        instructions["LD2"] = new LD2();
        instructions["LD3"] = new LD3();
        instructions["ST2"] = new ST2();
        instructions["ST3"] = new ST3();
        instructions["POS"] = new POS();
        instructions["PXL"] = new PXL();
        instructions["RND"] = new RND();
        instructions["CLR"] = new CLR();
        instructions["COS"] = new COS();
        instructions["SIN"] = new SIN();
        instructions["IN"] = new IN();
    }
}
