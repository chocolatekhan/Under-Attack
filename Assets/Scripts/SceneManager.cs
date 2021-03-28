using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    private int _totalScenes, _currentScene;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void LoadNextScene()
    {
        _totalScenes = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
        _currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;

        UnityEngine.SceneManagement.SceneManager.LoadScene((_currentScene + 1) % _totalScenes);
    }
}