using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray; 
	AudioSource musicPlayer;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (gameObject);	
	}

	void Start () {
		Scene scene = SceneManager.GetActiveScene();
		musicPlayer = GetComponent<AudioSource> ();
	}
	
	void OnLevelWasLoaded(int level) {
		AudioClip levelMusic = levelMusicChangeArray [level];

		if (levelMusic) {
			musicPlayer.Stop ();
			musicPlayer.clip = levelMusic;
			musicPlayer.loop = true;
			musicPlayer.Play ();
		}
	}
}
