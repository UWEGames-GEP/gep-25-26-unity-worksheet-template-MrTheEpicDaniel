using UnityEngine;
using System.Collections.Generic;
public class InventoryScript : MonoBehaviour
{
    public List<string> items = new List<string>();

    public void AddItemToInventory(string item_name) { items.Add(item_name); }
    public void RemoveItemFromInventory(string item_name) { items.Remove(item_name); }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
