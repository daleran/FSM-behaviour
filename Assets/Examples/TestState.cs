using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DaleranGames.FSMBehaviour;

public class TestState : FSMState
{
    [SerializeField]
    TestState nextState;

    [ContextMenu("Advance State")]
    public void AdvanceState()
    {
        if (enabled)
            FSM.CurrentState = nextState;
    }

    public override bool CanTransitionTo(FSMState state)
    {
        if (state == nextState)
            return true;
        else
            return false;
    }
}
