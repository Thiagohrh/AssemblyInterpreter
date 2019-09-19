public class LD2 : GenericInstruction
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

        Registers.registry["AC2"] = valueToLoadAC;

        Registers.registry["PC"]++;

        UpdateResultsToRegistry(valueToLoadAC);
    }
}
