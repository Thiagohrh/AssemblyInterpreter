using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST : GenericInstruction
{
    public override void Execute(string operandum)
    {
        if (operandum.Contains("#"))
        {
            //In this case this doesnt make much sense ...
        }
        else
        {
            int memoryIndex = GetDestinationIndexOfOperandum(operandum);
            Memory.memory[memoryIndex] = Registers.registry["AC"].ToString();
        }

        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
