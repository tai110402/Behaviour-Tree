using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : ScriptableObject
{
    public enum State
    {
        Running,
        Failure,
        Success
    }

    public State NodeState = State.Running;
    public bool Started = false;

    public State Update()
    {
        if (!Started)
        {
            OnStart();
            Started = true;
        }

        NodeState = OnUpdate();

        if (NodeState == State.Failure || NodeState == State.Success)
        {
            OnStop();
            Started = false;
        }

        return NodeState;
    }

    protected abstract void OnStart();
    protected abstract void OnStop();
    protected abstract State OnUpdate();
}
