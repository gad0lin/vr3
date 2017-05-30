using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coin;
	public GameObject poof;
	private GameObject poofObject;


    public void OnCoinClicked() {
		poofObject = Object.Instantiate (poof, coin.transform.position, Quaternion.identity) as GameObject;
		Object.Destroy (coin);

    }



}
