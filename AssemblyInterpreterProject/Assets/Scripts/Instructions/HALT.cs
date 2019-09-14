using UnityEngine;

public class HALT : GenericInstruction
{
    public override void Execute(string operandum)
    {
        Debug.Log("Halting the whole thing!");
    }
}
