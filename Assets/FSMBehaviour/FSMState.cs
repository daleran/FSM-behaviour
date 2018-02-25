using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.FSMBehaviour
{
    public abstract class FSMState : MonoBehaviour
    {
        [SerializeField]
        protected FSMBehaviour fsm;
        public virtual  FSMBehaviour FSM { get { return fsm; } } 

        public Action<FSMState> StateEnabled;
        public Action<FSMState> StateDisabled;

        public abstract bool CanTransitionTo(FSMState state);

        protected virtual void Awake()
        {
            enabled = false;
        }

        protected virtual void OnEnable()
        {
            if (StateEnabled != null)
                StateEnabled(this);
        }

        protected virtual void OnDisable()
        {
            if (StateDisabled != null)
                StateDisabled(this);
        }


    }
}
