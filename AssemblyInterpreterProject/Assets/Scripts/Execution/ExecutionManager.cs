using System.Collections;
using UnityEngine;

public class ExecutionManager : MonoBehaviour
{
    private bool freeToExecute = false;
    public bool FreeToExecute { get => freeToExecute; set => freeToExecute = value; }
    private bool runningCoroutine = false;
    public DisplayManager displayManager;
    private Runner runner = new Runner();
    private float automaticRunSpeed = 3.0f;

    private void Awake()
    {
        Runner.OnHaltReached -= SetupStopExecuting;
        Runner.OnHaltReached += SetupStopExecuting;
    }
    public void SetupToExecute()
    {
        FreeToExecute = true;
        displayManager.UpdateVisualPanels();
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

    public void SetupStopExecuting()
    {
        FreeToExecute = false;
        runningCoroutine = false;
        StopCoroutine(AutomaticExecution());
    }

    private void OnDestroy()
    {
        Runner.OnHaltReached -= SetupStopExecuting;
    }
}
