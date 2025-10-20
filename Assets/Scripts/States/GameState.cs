using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameState 
{
    public void onEnter()
    {
        Debug.Log("GameState.OnEnable Called!");
    }
    public void onExit()
    {
        Debug.Log("GameState.OnDisable Called!");
    }
}
