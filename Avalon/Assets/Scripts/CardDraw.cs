using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card{
	private int _id;
	private GameObject _Img;
    public Card (int id, GameObject Img){
        _id = id;
        _Img = Img;
    }
    public int GetId() {
        return _id;
    }
    public GameObject GetImg() {
        return _Img;
    }
}

public class CardDraw : MonoBehaviour {
    private List<Card> draw;
	public GameObject[] CardDefinition;
    Card GetCard(){
        // Get a random number between 0 and draw.size
        int rndcard = Random.Range(0, CardDefinition.Length);
        Debug.Log(rndcard);
        // Get the Card from the draw
        Card drawcard = draw.Find(x => x.GetId() == rndcard);
        // Remove the Card from draw
        draw.Remove(drawcard);
        // Return the Card
        return drawcard;
    }
    List<Card> initDraw(){
        List<Card> drawtmp = new List<Card>();
        for (int i = 0; i < CardDefinition.Length; i++){
            drawtmp.Add(new Card(i, CardDefinition[i]));
        }
        return drawtmp;
    }
	// Use this for initialization
	void Start () {
        Debug.Log(CardDefinition.Length);
        draw = initDraw();
        GetCard().GetImg().SetActive(true);
        Debug.Log(draw.Count);
	}
	
	// Update is called once per frame
	void Update () { 
		
	}
}
