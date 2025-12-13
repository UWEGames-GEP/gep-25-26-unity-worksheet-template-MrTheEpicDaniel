using NUnit.Framework;
using System.Collections.Generic;
//using UnityEditor.ShaderGraph.Serialization;
using UnityEngine;

public class StateManager : MonoBehaviour
{

    public GameState activeState;
    public GameState previousState;

    List<GameState> game_states = new List<GameState>();

    bool hasChangedState;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameState[] temp_States = { new MainMenuState(), new InventoryMenuState(), new PauseMenuState(), new SettingsMenuState(), new ActiveGameplayState() };
        DontDestroyOnLoad(gameObject);
        game_states.AddRange(temp_States);
        activeState = game_states[0];
        activeState.OnEnter();
    }

    // Update is called once per frame
    void Update()
    {
        activeState.Update();

    }
    private void LateUpdate()
    {
        if (hasChangedState)
        {
            hasChangedState = false;
        }
    }

    public void ChangeState(int new_state)
    {
        previousState = activeState;
        activeState = game_states[new_state];
        previousState.OnExit();
        activeState.OnEnter();
    }

    public int GetPreviousStateIndex()
    {
        return game_states.IndexOf(previousState);
    }

    public int GetActiveStateIndex() { return game_states.IndexOf(activeState); }
}
