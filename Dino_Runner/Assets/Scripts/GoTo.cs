using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTo : MonoBehaviour {

	public string destination;
	
	public void ToScene() {
		SceneManager.LoadScene(destination, LoadSceneMode.Single);
	}
}
