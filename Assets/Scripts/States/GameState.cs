using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class GameState 
{
    public virtual void OnEnter()
    {
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(sceneName: "Gameplay");
        Debug.Log("GameState.OnEnable Called!");
    }
    public virtual void OnExit()
    {
        Debug.Log("GameState.OnDisable Called!");
    }
    public virtual void Update() { }
}
