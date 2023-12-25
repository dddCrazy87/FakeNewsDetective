using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_player : MonoBehaviour
{
    private static Audio_player _instance;

    private void Awake() {
        if (_instance == null) {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    private AudioSource audioSource;
    [SerializeField] private BgmController bgmController;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.Play();
    }

    private bool isMusicPlaying = true;
    private void FixedUpdate() {
        if (bgmController.toPuaseBgm && isMusicPlaying) {
            audioSource.Pause();
            isMusicPlaying = false;
        }
        else if(!bgmController.toPuaseBgm && !isMusicPlaying) {
            audioSource.Play();
            isMusicPlaying = true;
        }
    }

    
}
