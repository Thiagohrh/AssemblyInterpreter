using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionManager : MonoBehaviour
{
    private bool freeToExecute = false;
    public bool FreeToExecute { get => freeToExecute; set => freeToExecute = value; }

    public DisplayManager displayManager;

    public void SetupToExecute()
    {
        FreeToExecute = true;
        //Should organize a few things. Highlight the current memory to be executed. Control input-based single instructions executing.
        //At a later stage, should also have a Coroutine in order to automate the process. Everything should be checked via freeToExecute boolian.
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
        //Debug.Log("Execute a single line!!!!!");

    }

    private void SetupStopExecuting()
    {
        FreeToExecute = false;
    }

}
