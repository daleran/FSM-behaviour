using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.FSMBehaviour
{
    public class FSMBehaviour : MonoBehaviour
    {
        public event Action<FSMState> StateChanged;

        [SerializeField]
        FSMState currentState;
        public virtual FSMState CurrentState
        {
            get { return currentState; }
            set
            {
                if (currentState.CanTransitionTo(value))
                {
                    currentState.enabled = false;
                    currentState = value;
                    currentState.enabled = true;

                    if (StateChanged != null)
                        StateChanged(currentState);
                }
                else
                    Debug.Log("FSM on " + gameObject.name + " cannot transition to " + value.name);
            }
        }

        // Use this for initialization
        protected virtual void Start()
        {
            currentState.enabled = true;

            if (StateChanged != null)
                StateChanged(currentState);
        }
    }
}

