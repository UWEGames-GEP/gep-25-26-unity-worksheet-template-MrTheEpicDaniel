//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class GameState 
{
    public StateManager stateManager;
    public virtual void OnEnter()
    {
        Debug.Log("GameState.OnEnable Called!");
    }
    public virtual void OnExit()
    {
        Debug.Log("GameState.OnDisable Called!");
    }
    public virtual void Update() { }
}
