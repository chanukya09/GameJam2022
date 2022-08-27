using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private IState currentlyRunningState;
    private IState previousState;
    public void ChangeState(IState newState)
    {   
        if(this.currentlyRunningState != null)
        {
            this.currentlyRunningState.Exit();
        }
        
        this.previousState = this.currentlyRunningState;
        this.currentlyRunningState = newState;
        this.currentlyRunningState.Enter();
    }
    public void ExecuteStateUpdate()
    {   
        var runningState=currentlyRunningState;
        if(runningState != null)
        {
            runningState.Execute();
        }
    }
    public void SwitchToPreviousState()
    {
        this.currentlyRunningState.Exit();
        this.currentlyRunningState = this.previousState;
        this.currentlyRunningState.Enter();
    }
}
