using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public static Action OnHaltReached;
    public void ExecuteInstruction()
    {
        string instruction = Memory.memory[Registers.registry["PC"]].Trim();

        string[] comandAndOperands = instruction.Split(' ');
        string comand = comandAndOperands[0];
        if (comandAndOperands.Length == 1) // Means said instruction doesnt have an operand with it.
        {
            if (comand == "HALT")
            {
                Instructions.instructions[comand].Execute("Whatever");
                OnHaltReached?.Invoke();
            }
            //Here it should tell the ExecutionManager that it has reached a stop function....but how...
            return;
        }
        string operand = comandAndOperands[1];
        Instructions.instructions[comand].Execute(operand);
    }
}
