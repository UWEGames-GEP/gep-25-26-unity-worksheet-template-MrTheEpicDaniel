using UnityEngine;

public class GameState : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("GameState.Awake Called");
    }
    private void Start()
    {
        Debug.Log("GameState.Start Called!");
    }
    private void OnEnable()
    {
        Debug.Log("GameState.OnEnable Called!");
    }
}
