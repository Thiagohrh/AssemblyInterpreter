using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionManager : MonoBehaviour
{
    private bool freeToExecute = false;
    public bool FreeToExecute { get => freeToExecute; set => freeToExecute = value; }
    private bool runningCoroutine = false;
    public DisplayManager displayManager;
    public Runner runner;

    public void SetupToExecute()
    {
        FreeToExecute = true;
        displayManager.UpdateVisualPanels();

        Runner.OnHaltReached -= SetupStopExecuting;
        Runner.OnHaltReached += SetupStopExecuting;
    }

    private void Update()
    {
        if (freeToExecute && !runningCoroutine)
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

    private void OnDestroy()
    {
        Runner.OnHaltReached -= SetupStopExecuting;
    }
}
