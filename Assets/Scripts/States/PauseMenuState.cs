using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenuState : MenuState
{
    Canvas pauseUI;
    public override void OnEnter()
    {
        stateManager = GameObject.FindAnyObjectByType<StateManager>();
        pauseUI = GameObject.FindAnyObjectByType<Canvas>();
        pauseUI.enabled = true;
        Time.timeScale = 0.0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("PauseMenuState.OnEnable Called!");
    }
    public override void OnExit()
    {
        Debug.Log("PauseMenuState.OnDisable Called!");
        pauseUI.enabled = false;
    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            stateManager.ChangeState(stateManager.GetPreviousStateIndex());
        }
    }
}
