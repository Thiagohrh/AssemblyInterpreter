using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADD : GenericInstruction
{
    public override void Execute(string operandum)
    {
        int operationResult = 0;
        if (operandum.Contains("#"))
        {
            operandum = operandum.Replace("#", "");
            Registers.registry["AC"] += int.Parse(operandum);
            operationResult = Registers.registry["AC"];
        }
        else
        {
            int memoryIndex = GetDestinationIndexOfOperandum(operandum);
            Registers.registry["AC"] += int.Parse(Memory.memory[memoryIndex]);
            operationResult = Registers.registry["AC"];
        }

        Registers.registry["PC"]++;

        UpdateResultsToRegistry(operationResult);
    }
}
