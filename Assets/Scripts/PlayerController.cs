using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;


public class PlayerController : ThirdPersonController
{
    //StateManager stateManager;
    //private void OnPause(InputValue value)
    //{
    //    if (value.isPressed)
    //    {
    //        Debug.Log("pause game");
    //        stateManager = GameObject.FindAnyObjectByType<StateManager>();
    //        stateManager.ChangeState(2);
    //    }
    //}
    void OnRemoveItem(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Remove Item");
            GetComponent<InventoryScript>().RemoveItemFromInventory();
        }
    }
}
