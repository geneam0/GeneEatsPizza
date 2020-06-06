using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaGenerator : MonoBehaviour {

	public ObjectPooler pizzaPool;
	public float distanceBetweenCoins;
	public void SpawnCoins(Vector3 start){
		GameObject pizza1 = pizzaPool.GetPooledObject ();
		pizza1.transform.position = start;
		pizza1.SetActive (true);

		GameObject pizza2 = pizzaPool.GetPooledObject ();
		pizza2.transform.position = new Vector3(start.x-distanceBetweenCoins,start.y, start.z);
		pizza2.SetActive (true);

		GameObject pizza3 = pizzaPool.GetPooledObject ();
		pizza2.transform.position = new Vector3(start.x+distanceBetweenCoins,start.y, start.z);
		pizza2.SetActive (true);
	}
}
