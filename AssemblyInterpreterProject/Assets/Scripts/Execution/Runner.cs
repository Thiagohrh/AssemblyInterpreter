using System;

public class Runner
{
    public static Action OnHaltReached;
    public void ExecuteInstruction()
    {
        string instruction = Memory.memory[Registers.registry["PC"]].Trim();

        string[] comandAndOperands = instruction.Split(' ');
        string comand = comandAndOperands[0];
        if (comandAndOperands.Length == 1) // Means said instruction doesnt have an operand with it.
        {
            Instructions.instructions[comand].Execute("Whatever");
            if (comand == "HALT")
            {
                OnHaltReached?.Invoke();
            }
            return;
        }
        string operand = comandAndOperands[1];
        Instructions.instructions[comand].Execute(operand);
    }
}
