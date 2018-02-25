# FSM Behaviour
A monbehaviour based finite state machine for Unity3D. 
## Features
- A simple framework that uses enables/disables monobehaviours as state changes
- C# Actions to hook in to for state changes
- Use monbehaviour funtions as part of the state machine such as Start, Enable, Update, OnTriggerEnter, Etc

## Usage
- Create custom states by deriving from FSMState
- Override CanTransitionTo(FSMState) to inform the state machine when the condition is met to change states
- Change states through your custom states or through the a custom class derived from FSMBehaviour
