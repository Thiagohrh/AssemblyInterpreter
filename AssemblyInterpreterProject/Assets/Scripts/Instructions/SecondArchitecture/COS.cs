using UnityEngine;

public class COS : GenericInstruction
{
    public override void Execute(string operandum)
    {

        Debug.Log("COS used! Not yet implemented!!!!");
        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
