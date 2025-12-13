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
        if (stateManager.GetActiveStateIndex() == 4)
        {
            if (items.Count > 0)
            {
                CollectableScript item = items[0];
                Vector3 currentPosition = transform.position;
                Vector3 forward = transform.forward;
                Vector3 newPosition = currentPosition + forward;
                newPosition += new Vector3(0, 1, 0);
                Quaternion currentRotatin = transform.rotation;
                Quaternion newRotation = currentRotatin * Quaternion.Euler(0, 0, 100);
                GameObject newItem = Instantiate(item.gameObject,newPosition,newRotation,worldItemsTransform);
                newItem.SetActive(true);
                items.Remove(item);
                Destroy(item.gameObject);
            }
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
