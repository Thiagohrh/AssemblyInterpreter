using UnityEngine;

public class RND : GenericInstruction
{
    public override void Execute(string operandum)
    {

        Debug.Log("RND used! Not yet implemented!!!!");
        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
