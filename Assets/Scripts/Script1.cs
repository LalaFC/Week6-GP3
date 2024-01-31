using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// .... Dictionary Test .... //
public class Script1 : MonoBehaviour
{
    Dictionary<string, int> BountyPirates = new Dictionary<string, int>()
    {
        { "Luffy", 30000000 },
        { "Chopper", 1000 }
    };

    Dictionary<string, string> CelestialDragon = new Dictionary<string, string>()
    {
        { "Saturn", "Egghead" }
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UpdateBounty("Luffy", 6000000);
            Debug.Log("PiratesCount: " + BountyPirates.Count);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddPirate("Kuma", 34000000);
            AddPirate("Dofi", 64000000);
            Debug.Log("Added Kuma. Added Dofi");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CelestialDragon.ContainsKey("Saturn") && CelestialDragon.ContainsValue("Egghead"))
            {
                DeletePirate("Chopper");
                Debug.Log("Chopper Deleted");
            }
        }
    }

    #region One Piece
    void UpdateBounty(string pirateName, int newBounty)
    {
        BountyPirates[pirateName] = newBounty;
    }

    void AddPirate(string pirateName, int Bounty)
    {
        BountyPirates.Add(pirateName, Bounty);
    }
    void DeletePirate(string pirateName)
    {
        BountyPirates.Remove(pirateName);
    }
    #endregion

 #region Celestial Dragon


#endregion
}
