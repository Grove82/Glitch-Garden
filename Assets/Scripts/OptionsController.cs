using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider, difficultySlider;
	public LevelManager levelManager;

	private MusicManager musicManager;
	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		volumeSlider.value = PlayerPrefManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefManager.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.SetVolume (volumeSlider.value);
	}

	public void SaveAndExit(){
		PlayerPrefManager.SetMasterVolumne (volumeSlider.value);
		PlayerPrefManager.SetDifficulty (difficultySlider.value);
		levelManager.LoadLevel ("Start");
	}

	public void SetDefaults(){
		volumeSlider.value =.8f;
		difficultySlider.value = 2f;
	}
}
