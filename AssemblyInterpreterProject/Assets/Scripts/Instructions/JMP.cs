using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JMP : GenericInstruction
{
    public override void Execute(string operandum)
    {
        if (operandum.Contains("#"))
        {
            operandum = operandum.Replace("#", "");
            Registers.registry["PC"] = int.Parse(operandum);
        }
        else
        {
            int memoryIndex = GetDestinationIndexOfOperandum(operandum);
            Registers.registry["PC"] = memoryIndex;
        }

    }
}
