using UnityEngine;
using System.Collections.Generic;
public class InventoryScript : MonoBehaviour
{
    public StateManager stateManager;
    public GameObject Collectables;

    public List<string> items = new List<string>();

    public void AddItemToInventory(string item_name) { items.Add(item_name); }
    public void RemoveItemFromInventory(string item_name) { items.Remove(item_name); }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stateManager = FindAnyObjectByType<StateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stateManager.GetActiveStateIndex() == 4)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                AddItemToInventory("GenericItem");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                RemoveItemFromInventory("GenericItem");
            }
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Collectable collisionItem = hit.gameObject.GetComponent<Collectable>();
    }
}
