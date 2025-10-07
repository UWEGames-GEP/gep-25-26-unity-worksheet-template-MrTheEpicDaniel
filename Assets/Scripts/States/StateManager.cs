using UnityEditor.ShaderGraph.Serialization;
using UnityEngine;

public class StateManager : MonoBehaviour
{

    GameState activeState;
    GameState previousState;

    bool hasChangedState;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        previousState = new MainMenuState();
        activeState = new MainMenuState();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<GameState>().enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            GetComponent<GameState>().enabled = false;
        }

    }
    private void LateUpdate()
    {

    }
}
