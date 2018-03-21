using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//public class Vote {

//	private GameObject _Yes;
//	private GameObject _No;
//	public Vote(GameObject Yes, GameObject No)
//	{
//		_Yes = Yes;
//		_No = No;
//	}
//	public GameObject GetYes()
//	{
//		return _Yes;
//	}
//	public GameObject GetNo()
//	{
//		return _No;
//	}

//}
public class Player 
{
      private GameObject _PlayerId;
      private int _Nametag;
      private bool _PlayerStatus;
      public Player(GameObject PlayerId, int Nametag, bool PlayerStatus)
      {
        _PlayerId = PlayerId;
        _Nametag = Nametag;
        _PlayerStatus = PlayerStatus;
      }
      public GameObject GetPlayerId()
      {
        return _PlayerId;
      }
      public int GetNametag()
      {
        return _Nametag;
      }   
      public bool GetPlayerStatus()
      {
        return _PlayerStatus;
      }   
}

public class VoteSys : MonoBehaviour {
    public GameObject yes;
    public GameObject no;
    public GameObject yes_message;
    public GameObject no_message;
    public GameObject[] PlayerDefinition;
    public int no_vote = 0;
    public int yes_vote = 0;
    private List<Player> Plist;
    // Use this for initialization
    void Start() {
        yes.GetComponent<Button>().onClick.AddListener(Yesclicked);
    
        no.GetComponent<Button>().onClick.AddListener(Noclicked);
    }
    //Player GetPlayer()
    //{
    //    int rndplayer = Random.Range(0, PlayerDefinition.Length);
    //    Debug.Log(rndplayer);
    //    Card drawcard = Plist.Find(x => x.GetNametag() == rndplayer);
    //}
    private void Noclicked()
    {
        no_vote += 1;
        Debug.Log(no_vote);
        if (no_vote > (8 / 2))
        {
            no_message.SetActive(true);
        }
    }
    private void Yesclicked()
    {
        if (yes_vote == 0){
            yes_vote += 1;
        }
        Debug.Log(yes_vote);
        if (yes_vote > (8 / 2))
        //if (yes_vote > (CardDefinition.size / 2))
        {
            yes_message.SetActive(true);
        }
    }
	// Update is called once per frame
	void Update() {

	}


   

}
