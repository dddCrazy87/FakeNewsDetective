using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyController : MonoBehaviour
{
    [SerializeField] GameObject story1_go, story2_go;
    [SerializeField] story story1_script, story2_script;
    [SerializeField] private Player player;
    [SerializeField] private BgmController bgmController;
    [SerializeField] private InstructionAndMission instructionAndMission;
    private AudioSource audioSource;
    private bool isMusicPlaying = false;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
        if(instructionAndMission.instructionID == 0) {
            story1_go.SetActive(true);
            story1_script.isAnimating = true;
            player.isMove = false;
            audioSource.loop = true;
            if(!isMusicPlaying) {
                audioSource.Play();
                isMusicPlaying = true;
            }
            bgmController.toPuaseBgm = true;
        }
    }


    public void nextBtn() {
        story1_go.SetActive(false);
        story2_go.SetActive(true);
        if(!story2_script.isAnimated) story2_script.isAnimating = true;
    }

    public void prevBtn() {
        story1_go.SetActive(true);
        story2_go.SetActive(false);
    }

    public void okBtn() {
        story1_go.SetActive(false);
        story2_go.SetActive(false);
        player.isMove = true;
        if(isMusicPlaying) {
            audioSource.Pause();;
            isMusicPlaying = false;
        }
        
        bgmController.toPuaseBgm = false;
    }
}
