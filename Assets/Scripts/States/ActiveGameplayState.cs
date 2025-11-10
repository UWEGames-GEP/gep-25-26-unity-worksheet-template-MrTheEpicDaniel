using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveGameplayState : GameState
{
    public override void OnEnter()
    {
        stateManager = GameObject.FindAnyObjectByType<StateManager>();
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (SceneManager.GetActiveScene().name != "Gameplay")
        {
            SceneManager.LoadScene(sceneName: "Gameplay");
        }
        Debug.Log("ActiveGameplayState.OnEnable Called!");

    }
    public override void OnExit()
    {
        Debug.Log("ActiveGameplayState.OnDisable Called!");
    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            Debug.Log("Escape key pressed!");
            stateManager.ChangeState(2);
        }
    }

}
