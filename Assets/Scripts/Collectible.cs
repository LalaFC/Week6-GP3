using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectible : MonoBehaviour
{
    public string ItemName;
    public int ItemID;
    public int Quatity;

    InventorySystem InventorySystems;

    // Start is called before the first frame update
    void Start()
    {
        InventorySystems = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    }

    // Update is called once per frame
    public void CollectItem()
    {
        Items itemtoAdd = new Items(ItemName, ItemID, Quatity);
        Destroy(gameObject);
    }
}
