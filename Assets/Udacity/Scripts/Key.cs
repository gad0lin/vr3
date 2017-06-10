using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject clickedObject;
	public GameObject poofReference;
	private GameObject poofObject;
    public Door door;

    public void Update()
    {
        if (poofObject == null)
             clickedObject.transform.Rotate(0, 0, Time.deltaTime * 20);
    }

    public void OnKeyClicked()
	{
        poofObject = Object.Instantiate(poofReference, clickedObject.transform.position, Quaternion.Euler(0, 0, -90)) as GameObject;
        door.Unlock();
        Object.Destroy(clickedObject);
    }

}
