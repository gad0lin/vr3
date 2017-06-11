using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coin;
	public GameObject poof;
	private GameObject poofObject;

    private Vector3[] randomPosition = new Vector3[]{ new Vector3(25.47f, 1.208f, 85.36f), new Vector3(16.4f, 1.208f, 89.66f), new Vector3(8.54f, 1.208f, 89.66f), new Vector3(10.58f, 1.208f, 77.81f), new Vector3(-7, 0, -8.4f), new Vector3(16.38f, 1.35f, 90.2f)}; 
    public void Start() {
        /* Vector3 intialPosition =   randomPosition[Random.Range(0, randomPosition.Length)]; - it's hard to test with real random position
        coin.transform.position = intialPosition;

        Debug.Log(intialPosition); */
    }

    public void OnCoinClicked() {
		poofObject = Object.Instantiate (poof, coin.transform.position, Quaternion.Euler(0, 0, -90)) as GameObject;
        

        Object.Destroy (coin);

    }



}
