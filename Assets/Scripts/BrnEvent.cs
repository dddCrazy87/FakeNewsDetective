using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BrnEvent : MonoBehaviour
{
    private static BrnEvent _instance;

    private void Awake() {
        if (_instance == null) {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    public AudioSource buttonClickSound;
    private Button[] allButtons;

    private void OnEnable() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        allButtons = GameObject.FindObjectsOfType<Button>(true);
        foreach (Button button in allButtons) {
            button.onClick.AddListener(() => PlayButtonClickSound());
        }
    }

    private void OnDisable() {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    void PlayButtonClickSound() {
        buttonClickSound.Play();
    }
}
