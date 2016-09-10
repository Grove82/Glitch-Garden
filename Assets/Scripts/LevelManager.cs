using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		print ("level load requested " + name);
		SceneManager.LoadScene (name);
	}

	public void QuitRequest() {
		print ("I want to quit");
		Application.Quit ();
	}

	public void LoadNextLevel() {
		
	}
}
