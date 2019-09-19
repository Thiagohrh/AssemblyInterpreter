using UnityEngine;

public class CLR : GenericInstruction
{
    public override void Execute(string operandum)
    {

        Debug.Log("CLR used! Not yet implemented!!!!");
        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
