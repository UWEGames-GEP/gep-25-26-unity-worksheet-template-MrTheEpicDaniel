using UnityEngine;
using System.Collections.Generic;
public class InventoryScript : MonoBehaviour
{
    public StateManager stateManager;
    public Transform worldItemsTransform;

    public List<CollectableScript> items = new List<CollectableScript>();

    public void AddItemToInventory(CollectableScript item) { items.Add(item); }
    public void RemoveItemFromInventory(CollectableScript item) { items.Remove(item); }
    public void RemoveItemFromInventory()
    {
        if (stateManager.GetActiveStateIndex() == 4) { 
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stateManager = FindAnyObjectByType<StateManager>();

        Transform worldItemsTransform = GameObject.Find("WorldItems").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        CollectableScript collisionItem = hit.gameObject.GetComponent<CollectableScript>();

        if (collisionItem != null)
        {
            items.Add(collisionItem);
            collisionItem.gameObject.SetActive(false);
        }
    }
}
