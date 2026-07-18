using UnityEngine;
enum GameState
{
    PLAY,
    PAUSE
}
public class GameManager : MonoBehaviour
{
    GameState state;
    bool hasChangedState;
    public GameObject inventoryUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (state == GameState.PLAY)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                state = GameState.PAUSE;
                hasChangedState = true;
            }
        }
        else if (state == GameState.PAUSE)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                state = GameState.PLAY;
                hasChangedState = true;
            }
        }
    }
    private void LateUpdate()
    {
        if (hasChangedState)
        {
            hasChangedState = false;

            if (state == GameState.PLAY)
            {
                Time.timeScale = 1.0f;
                inventoryUI.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;

            }
            else if (state == GameState.PAUSE)
            {
                Time.timeScale = 0.0f;
                inventoryUI.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
        }

    }
}
