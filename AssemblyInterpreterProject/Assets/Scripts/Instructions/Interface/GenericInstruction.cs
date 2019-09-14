using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericInstruction : IInstructionable<string>
{
    virtual public void Execute(string operandum){}

    protected int GetDestinationIndexOfOperandum(string operandum)
    {
        int value = 0;
        if (Registers.registry.ContainsKey(operandum))
        {
            value = Registers.registry[operandum];
            return value;
        }
        else if (operandum.Contains("i"))
        {
            string[] operandumArray = operandum.Split(',');
            if (Registers.registry.ContainsKey(operandumArray[0]))
            {
                value = int.Parse(Memory.memory[Registers.registry[operandumArray[0]]]);
                return value;
            }
            if (true)
            {
                value = int.Parse(Memory.memory[int.Parse(operandumArray[0])]);
                return value;
            }
        }
        return int.Parse(operandum);
    }

    protected void UpdateResultsToRegistry(int result)
    {
        if (Mathf.Sign(result) == 1) //Positive value
        {
            Registers.registry["N"] = 0;
            Registers.registry["Z"] = 0;
        }
        else if (Mathf.Sign(result) == -1)
        {
            Registers.registry["N"] = 1;
            Registers.registry["Z"] = 0;
        }
        else
        {
            Registers.registry["N"] = 0;
            Registers.registry["Z"] = 1;
        }
    }
}
