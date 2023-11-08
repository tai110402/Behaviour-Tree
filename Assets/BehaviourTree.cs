using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class BehaviourTree : ScriptableObject
{
    public Node RootNode;
    public Node.State TreeState = Node.State.Running;

    public Node.State Update()
    {
        if (RootNode.NodeState == Node.State.Running)
        {
            return RootNode.Update();
        }
        return TreeState;
    }
}
