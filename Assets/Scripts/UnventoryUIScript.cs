using System.Collections.Generic;
using UnityEngine;

public class UnventoryUIScript : MonoBehaviour
{
    public InventoryScript inventory;
    public List<GameObject> inventoryUIButtons = new List<GameObject>();

    private void OnEnable()
    {
        RefreshInventory();
    }

    void RefreshInventory()
    {
        foreach (GameObject uiButton in inventoryUIButtons)
        {
            uiButton.SetActive(false);
        }

        for (int i = 0; i < inventory.items.Count; i++)
        {
            if(i < inventoryUIButtons.Count)
            {
                InventoryUIButton uIButton = inventoryUIButtons[i].GetComponent<InventoryUIButton>();
                CollectableScript item = inventory.items[i];

                uIButton.gameObject.SetActive(true);
                uIButton.SetButton(item);
            }
        }
    }
    public void OnInventoryUIButton(int i)
    {
        inventory.RemoveItemFromInventory(i);
        RefreshInventory();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
