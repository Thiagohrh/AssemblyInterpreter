using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public void ExecuteInstruction()
    {
        //Should get the instruction...so....
        string instruction = Memory.memory[Registers.registry["PC"]].Trim();

        //Should separate it...normally there is a command and an operand, so should have two positions in a string []
        string[] comandAndOperands = instruction.Split(' ');
        string comand = comandAndOperands[0];
        if (comandAndOperands.Length == 1) // Means said instruction doesnt have an operand with it.
        {
            Instructions.instructions[comand].Execute("Whatever");
            return;
        }
        string operand = comandAndOperands[1];
        Instructions.instructions[comand].Execute(operand);
    }
}
