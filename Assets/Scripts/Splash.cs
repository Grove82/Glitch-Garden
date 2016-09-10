using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	public LevelManager levels;
	private AudioSource audioPlayer;

	// Use this for initialization
	void Start () {
		audioPlayer = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!audioPlayer.isPlaying) {
			levels.LoadLevel ("Start");
		}
	}
}
