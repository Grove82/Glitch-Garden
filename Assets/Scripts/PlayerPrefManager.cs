using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefManager : MonoBehaviour {

	const string MASTER_VOLUMNE_KEY = "master_volume";
	const string DIFFICULTY_KEY = "dificulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolumne(float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUMNE_KEY, volume);
		} else {
			Debug.LogError ("invalid volumne entered");
		}
	}

	public static float GetMasterVolume() {
		return PlayerPrefs.GetFloat (MASTER_VOLUMNE_KEY);
	}

	public static void SetDifficulty(float difficulty) {
		if (difficulty >= 1f && difficulty <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError ("invalid difficulty entered");
		}
	}

	public static float GetDifficulty() {
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}

	public static void UnlockLevel(int level) {
		if (level < SceneManager.sceneCountInBuildSettings - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level, 1);
		} else {
			Debug.LogError ("trying to unlock invalid level #");
		}
	}

	public static bool IsLevelLocked(int level) {

		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level);
		bool isLevelLocked = (levelValue == 1);

		if (level < SceneManager.sceneCountInBuildSettings - 1) {
			return isLevelLocked;
		} else {
			Debug.LogError ("invalid level int passed to isLeveLocked");
			return false;
		}
	}
}

