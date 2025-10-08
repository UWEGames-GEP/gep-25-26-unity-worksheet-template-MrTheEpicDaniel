using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameState : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("GameState.OnEnable Called!");
    }
    private void OnDisable()
    {
        Debug.Log("GameState.OnDisable Called!");
    }
}
