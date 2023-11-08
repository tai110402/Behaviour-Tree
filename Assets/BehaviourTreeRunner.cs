using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTreeRunner : MonoBehaviour
{
    private BehaviourTree _tree;

    // Start is called before the first frame update
    void Start()
    {
        _tree = ScriptableObject.CreateInstance<BehaviourTree>();

        var log = ScriptableObject.CreateInstance<DebugLogNode>();
        log.Message = "HELLO YOUTUBEEE!!!";

        _tree.RootNode = log;
    }

    // Update is called once per frame
    void Update()
    {
        _tree.Update();
    }
}
