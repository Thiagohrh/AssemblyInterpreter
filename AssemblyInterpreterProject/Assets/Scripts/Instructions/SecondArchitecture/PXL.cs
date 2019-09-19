using UnityEngine;

public class PXL : GenericInstruction
{
    public override void Execute(string operandum)
    {

        Debug.Log("PXL used! Not yet implemented!!!!");
        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
