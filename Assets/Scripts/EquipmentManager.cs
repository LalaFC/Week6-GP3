using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class HandWeapon
{
    public string Name;
    public string Description;
    public GameObject Model;
    public int ID;
    public bool hasEffects;
}

public class EquipmentManager : MonoBehaviour
{
    public static EquipmentManager Instance { get; private set; }
    [SerializeField]
    private List<HandWeapon> handWeapon = new();

    public List<HandWeapon> HandWeapons
    {
        get { return handWeapon; }
    }

    private void Awake()
    {
        if (Instance !=null && Instance != this )
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
