using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{
    public float detectionRange;
    public LayerMask itemLayerMask;
    public KeyCode CK; //Collection KeyCode
    public InventorySystem inventorySystems;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DetectItems();
    }
    void DetectItems()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.forward);
        if (Physics.Raycast(ray, out hit,detectionRange,itemLayerMask))
        {
            Debug.Log("Item Detected " + hit.collider.gameObject.name);
        }
        if (Input.GetKeyDown(CK))
        {
            hit.collider.gameObject.GetComponent<Collectible>().CollectItem();
        }
    }
    public void CollectItem(Items item)
    {
        inventorySystems.AddItem(item);
        Debug.Log("Item Collected");
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector3.forward * detectionRange);
    }

}
