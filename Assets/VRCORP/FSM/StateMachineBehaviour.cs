using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineBehaviour : MonoBehaviour
{

    private AbstractState _currentState;
    private bool IsCurrentStateEmpty
    {
        get
        {
            return _currentState == null;
        }
    }

    void Update()
    {
        if (!IsCurrentStateEmpty) _currentState.Update();
    }

    public void Set (AbstractState state)
    {
        if (!IsCurrentStateEmpty)
        {
            if (_currentState.OnExit()) _currentState = state;
        } else _currentState = state;

        _currentState.Start();
    }
}
