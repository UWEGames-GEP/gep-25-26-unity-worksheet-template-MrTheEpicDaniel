using UnityEngine;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    [SerializeField] Button resumeButton;
    StateManager stateManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        stateManager = FindAnyObjectByType<StateManager>();
        canvas.enabled = false;
        resumeButton.onClick.AddListener(delegate { stateManager.ChangeState(4); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        
    }

    void TaskOnClick() { stateManager.ChangeState(4); }
}
