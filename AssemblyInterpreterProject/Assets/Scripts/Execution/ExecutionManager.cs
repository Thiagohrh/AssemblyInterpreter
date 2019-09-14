using System.Collections;
using UnityEngine;

public class ExecutionManager : MonoBehaviour
{
    private bool freeToExecute = false;
    public bool FreeToExecute { get => freeToExecute; set => freeToExecute = value; }
    private bool runningCoroutine = false;
    public DisplayManager displayManager;
    private Runner runner = new Runner();
    private float automaticRunSpeed = 1.8f;

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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                runningCoroutine = true;
                StartCoroutine(AutomaticExecution());
            }
        }
        else if (runningCoroutine && Input.GetKeyDown(KeyCode.Space))
        {
            runningCoroutine = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private IEnumerator AutomaticExecution()
    {
        while (runningCoroutine)
        {
            ExecuteSingleCommand();
            yield return new WaitForSeconds(1 / automaticRunSpeed);
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
        StopCoroutine(AutomaticExecution());
        runningCoroutine = false;
    }

    private void OnDestroy()
    {
        Runner.OnHaltReached -= SetupStopExecuting;
    }
}
