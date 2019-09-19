public class POS : GenericInstruction
{
    public override void Execute(string operandum)
    {
        Registers.DrawCursor.X = Registers.registry["AC"];
        Registers.DrawCursor.Y = Registers.registry["AC2"];

        Registers.registry["PC"]++;

        UpdateResultsToRegistry(Registers.registry["AC"]);
    }
}
