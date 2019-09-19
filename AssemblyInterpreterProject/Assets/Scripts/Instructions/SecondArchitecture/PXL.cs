using UnityEngine;

public class PXL : GenericInstruction
{
    public override void Execute(string operandum)
    {

        ImageDisplay.DrawPixelOnScreen();
        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
