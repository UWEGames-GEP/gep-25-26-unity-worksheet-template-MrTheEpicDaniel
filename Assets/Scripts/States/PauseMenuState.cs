using UnityEngine;

public class PauseMenuState : MenuState
{
    public override void OnEnter()
    {
    stateManager = GameObject.FindAnyObjectByType<StateManager>();
    Time.timeScale = 0.0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("PauseMenuState.OnEnable Called!");

    }
    public override void OnExit()
    {
        Debug.Log("PauseMenuState.OnDisable Called!");
    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            stateManager.ChangeState(stateManager.GetPreviousStateIndex());
        }
    }
}
