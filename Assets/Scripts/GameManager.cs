/*
 * Jaden Pleasants
 * Assignment 6
 * Singleton game manager
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager> {

    public int score;

    private string CurrentLevelName = string.Empty;

    public void LoadLevel(string levelName) {
        var ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null) {
            Debug.LogError($"[GameManager] Unable to load level {levelName}");
            return;
        }
        CurrentLevelName = levelName;
    }

    public void UnloadLevel(string levelName) {
        var ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null) {
            Debug.LogError($"[GameManager] Unable to unload level {levelName}");
            return;
        }
    }
}
