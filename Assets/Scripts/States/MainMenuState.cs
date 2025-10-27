using UnityEngine;

public class MainMenuState : MenuState
{
    public override void OnEnter()
    {
        Debug.Log("MainMenuState.OnEnable Called!");
        Debug.Log(Cursor.lockState);
        Time.timeScale = 0f;
        if (Cursor.visible == false)
        {
            Cursor.visible = true;
        }
    }
    public override void OnExit()
    {
        Debug.Log("MainMenuState.OnDisable Called!");
        GameObject.Find("/MainMenu").SetActive(false);
        
    }
    public override void Update()
    {
        
    }
}
