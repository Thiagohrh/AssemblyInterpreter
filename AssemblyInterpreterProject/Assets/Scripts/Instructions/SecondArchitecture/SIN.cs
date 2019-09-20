using UnityEngine;

public class SIN : GenericInstruction
{
    public override void Execute(string operandum)
    {

        Debug.Log("SIN used! Not yet implemented!!!!");
        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
