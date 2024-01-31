using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializableValuePair<Tkey, TValue>
{
    public Tkey Key;
    public TValue Value;
    public SerializableValuePair(Tkey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}

public class InventorySystem : MonoBehaviour
{
    [SerializeField]
    List<SerializableValuePair<int, Items>> inventoryList = new();

    [SerializeField]
    private Dictionary<int, Items> inventory = new Dictionary<int, Items>();
    public void AddItem(Items item)
    {
        if (inventory.ContainsKey(item.ID)) { inventory[item.ID] = item; }
        else { inventory[item.ID] = item;}
        SyncDictList();
    }
    public bool RemoveItem(int itemID)
    {
        bool _remove = inventory.Remove(itemID);
        if (_remove ) SyncDictList();
        return _remove;
    }
    public bool CheckItem(int itemID)
    {
        return inventory.ContainsKey(itemID);
    }

    public void SyncDictList()
    {
        inventoryList.Clear();
        foreach (var pair in inventoryList)
        {
            inventoryList.Add(new SerializableValuePair<int, Items> ( pair.Key, pair.Value ));
        }

    }

}


