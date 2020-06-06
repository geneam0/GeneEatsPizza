using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatGenerator : MonoBehaviour {

	public ObjectPooler CatPool;
	public float distanceBetweenCoins;

	public void SpawnCoins(Vector3 startPosition){
		GameObject cat1 = CatPool.GetPooledObject ();
		cat1.transform.position = startPosition;
		cat1.SetActive (true);

		GameObject cat2 = CatPool.GetPooledObject ();
		cat2.transform.position = new Vector3(startPosition.x-distanceBetweenCoins,startPosition.y, startPosition.z);
		cat2.SetActive (true);

		GameObject cat3 = CatPool.GetPooledObject ();
		cat3.transform.position = new Vector3(startPosition.x+distanceBetweenCoins,startPosition.y, startPosition.z);
		cat3.SetActive (true);
	}
}
