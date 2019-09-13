public class Memory
{
    public static string[] memory = new string[150];

    public Memory()
    {
        CleanMemory();
    }
    public static void CleanMemory()
    {
        for (int i = 0; i < memory.Length; i++)
        {
            memory[i] = string.Empty;
        }
    }
}
