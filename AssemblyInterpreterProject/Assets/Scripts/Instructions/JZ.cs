using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JZ : GenericInstruction
{
    public override void Execute(string operandum)
    {
        if (Registers.registry["Z"] == 1)
        {
            if (operandum.Contains("#"))
            {
                operandum = operandum.Replace("#", "");
                Registers.registry["PC"] = int.Parse(operandum);
                return;
            }
            else
            {
                int memoryIndex = GetDestinationIndexOfOperandum(operandum);
                Registers.registry["PC"] = memoryIndex;
            }
            
        }
        else
        {
            Registers.registry["PC"]++;
        }
    }
}
