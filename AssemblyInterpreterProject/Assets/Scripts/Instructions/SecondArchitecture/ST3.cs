public class ST3 : GenericInstruction
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
            Memory.memory[memoryIndex] = Registers.registry["AC3"].ToString();
        }

        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
