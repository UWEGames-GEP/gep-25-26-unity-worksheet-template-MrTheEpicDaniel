using NUnit.Framework;
using UnityEditor.ShaderGraph.Serialization;
using UnityEngine;

public class StateManager : MonoBehaviour
{

    public GameState activeState;
    public GameState previousState;

    GameState[] game_states = { new MainMenuState(), new InventoryMenuState(), new PauseMenuState(), new SettingsMenuState(), new ActiveGameplayState() };

    bool hasChangedState;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(gameObject);
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
}
