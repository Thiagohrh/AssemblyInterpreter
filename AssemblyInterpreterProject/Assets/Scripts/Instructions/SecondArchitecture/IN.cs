using UnityEngine;

public class IN : GenericInstruction
{
    public override void Execute(string operandum)
    {

        Debug.Log("IN used! Not yet implemented!!!!");
        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
