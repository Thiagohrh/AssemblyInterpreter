using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LD : GenericInstruction
{
    public override void Execute(string operandum)
    {
        int valueToLoadAC = 0;

        if (operandum.Contains("#")) // Then its absolute value... just  do whatever.
        {
            operandum = operandum.Replace("#", "");
            valueToLoadAC = int.Parse(operandum);
        }
        else
        {
            int memoryIndex = GetDestinationIndexOfOperandum(operandum);
            valueToLoadAC = int.Parse(Memory.memory[memoryIndex]);
        }

        Registers.registry["AC"] = valueToLoadAC;

        Registers.registry["PC"]++;

        UpdateResultsToRegistry(valueToLoadAC);
    }
}
