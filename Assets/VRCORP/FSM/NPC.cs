using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour
{

    AbstractState[] states = new AbstractState[]
    {
        new Idle(),
        new Move(),
        new Attack()
    };

    StateMachineBehaviour stateMachineBehaviour
    {
        get
        {
            if (cashedStateMachineBehaviour == null) cashedStateMachineBehaviour = GetComponent<StateMachineBehaviour>();
            return cashedStateMachineBehaviour;
        }
    }

    StateMachineBehaviour cashedStateMachineBehaviour;

    int stateIndex = 0;

    private void Start()
    {
        stateMachineBehaviour.Set(states[stateIndex]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (stateIndex + 1 == states.Length) stateIndex = 0; else stateIndex++;
            stateMachineBehaviour.Set(states[stateIndex]);
        }
    }
}
