using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionManager : MonoBehaviour
{
    private bool freeToExecute = false;
    public bool FreeToExecute { get => freeToExecute; set => freeToExecute = value; }
    public DisplayManager displayManager;
    public Runner runner;

    public void SetupToExecute()
    {
        FreeToExecute = true;
        displayManager.UpdateVisualPanels();
    }

    private void Update()
    {
        if (freeToExecute)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                ExecuteSingleCommand();
            }
        }
    }
    private void ExecuteSingleCommand()
    {
        runner.ExecuteInstruction();
        displayManager.UpdateVisualPanels();
    }

    private void SetupStopExecuting()
    {
        FreeToExecute = false;
    }
}
