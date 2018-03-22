using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodPlayer
{
    private bool Merlin = true;
    private string _Merlin = "Merlin";
    private bool Preseval = true;
    private string _Preseval = "Preseval";
    private bool Peon = true;
    private string _Peon = "Peon";
    private bool Asasin = false;
    private string _Asasin = "Asasin";
    private bool Mordred = false;
    private string _Mordred = "Mordred";
    private bool Morgana = false;
    private string _Morgana = "Morgana";      
    private bool Groot = false;
    private string _Groot = "Groot";
    private bool BadPeon = false;
    private string _BadPeon = "BadPeon";

    //public GoodPlayer(bool Merlin, bool Preseval, bool Peon, bool Assasin, bool Mordred, bool M, bool Groot, bool BadPeon);
    public bool GetGoodPlayer()
    {
        return Merlin;
        return Preseval;
        return Peon;
        return Asasin;
        return Mordred;
        return Morgana;                           
        return Merlin;
        return BadPeon;
    }
    public string GetRole() 
    {
        return _Merlin;
        return _Preseval;
        return _Peon;
        return _Asasin;
        return _Mordred;
        return _Morgana;
        return _Groot;
        return _BadPeon;
    }
}

public class Game : MonoBehaviour {


    private List<GoodPlayer> BoolPlayer;
    public string Role;
    public bool BoolRole;
	// Use this for initialization
	void Start () {
        
      // Role = GoodPlayer GetRole ;

        if ((Role == "Morgana") || (Role == "Asasin") || (Role == "Mordred") || (Role == "Groot") || (Role == "BadPeon"))
        {
            BoolRole = true;
                if ((Role == "Morgana") || (Role == "Asasin") || (Role == "Mordred") || (Role == "Groot") || (Role == "BadPeon"))
            {
                // Display odher bad guys witouht Groot 
            }
        }
        else if ((Role == "Merlin") || (Role == "Perseval") || (Role == "Peon"))
        {
            BoolRole = false;
            if (Role == "Merlin")
            {
                // Display Morgana && Mordred
            }
            else if (Role == "Perceval")
            {
                // Display Merlin && Mordred
            } 
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
