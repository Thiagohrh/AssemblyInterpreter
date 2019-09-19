using UnityEngine;

public class CLR : GenericInstruction
{
    public override void Execute(string operandum)
    {
        ImageDisplay.ClearPixelsOnScreen();
        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
