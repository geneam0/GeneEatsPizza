using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepSound : MonoBehaviour {
	private static KeepSound instance = null;
	public static KeepSound Instance {
		get { return instance; }
	}
		
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}			
		if (SceneManager.GetActiveScene ().buildIndex == 3) {
			Destroy (this.gameObject);
		} else {
			DontDestroyOnLoad (this.gameObject);
		}
	}
}
