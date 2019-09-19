using UnityEngine;

public class NewCodeLoader : MonoBehaviour
{
    public ExecutionManager executionManager;
    public DisplayManager displayManager;
    public void LoadNewAssembly(string assemblyCode)
    {
        executionManager.SetupStopExecuting();

        Registers.ClearnRegisters();
        Memory.CleanMemory();

        displayManager.DisplayAssemblyCodeText(assemblyCode);

        LineParserer lineParserer = new LineParserer();
        string[] linesInFile = assemblyCode.Split('\n');

        foreach (string line in linesInFile)
        {
            lineParserer.ParseLine(line);
        }

        displayManager.Reload();
        displayManager.PopulateVisualMemoryArray();
        ImageDisplay.ClearPixelsOnScreen();

        executionManager.SetupToExecute();
    }
}
