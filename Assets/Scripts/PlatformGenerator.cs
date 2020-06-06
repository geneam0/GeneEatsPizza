using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;

	private float platformWidth;

	public ObjectPooler theObjectPool;

	private PizzaGenerator thePizzaGenerator;
	public float randomCoinThreshold;

	private CatGenerator theCatGenerator;
	public float randomCatThreshold;

	// Use this for initialization
	void Start () {
		platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
		thePizzaGenerator = FindObjectOfType<PizzaGenerator> ();
		theCatGenerator = FindObjectOfType <CatGenerator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < generationPoint.position.x) {
			transform.position = new Vector3 (transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
			//Instantiate (thePlatform, transform.position, transform.rotation);
			GameObject newPlatform = theObjectPool.GetPooledObject();
			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive (true);
			Vector3 location = new Vector3(transform.position.x,transform.position.y+1f, transform.position.z);
			if(Random.Range(0f,100f)<randomCoinThreshold){
				thePizzaGenerator.SpawnCoins (location);
			}
			Vector3 otherlocation = new Vector3(transform.position.x,transform.position.y+4.5f, transform.position.z);
			if(Random.Range(0f,100f)<randomCatThreshold && otherlocation!=location){
				theCatGenerator.SpawnCoins (otherlocation);
			}
		}
	}
}
