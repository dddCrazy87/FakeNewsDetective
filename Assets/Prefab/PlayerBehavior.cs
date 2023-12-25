using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Player player;
    private AudioSource walkAudio;
    private bool isPlayingWalkAudio = false;
    
   private void Start() {
        rb = GetComponent<Rigidbody2D>();
        walkAudio = GetComponent<AudioSource>();
        player.isMove = true;
        walkAudio.Pause();
        isPlayingWalkAudio = false;
    }

    public bool isPlayingOtherAnim = false;
    private void Update() {
        if(isPlayingOtherAnim) return;
        if(!player.isMove) {
            GetComponent<Animator>().SetBool("walk", false);
            rb.velocity = new Vector2(0, 0).normalized * moveSpeed;
            if(isPlayingWalkAudio) {
                walkAudio.Pause();
                isPlayingWalkAudio = false;
            }
            return;
        }
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement.normalized * moveSpeed;
        if(moveX > 0) {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if(moveX < 0) {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if(moveX != 0 || moveY != 0) {
            if(!isPlayingWalkAudio) {
                walkAudio.Play();
                isPlayingWalkAudio = true;
            }
            GetComponent<Animator>().SetBool("walk", true);
        }
        else {
            if(isPlayingWalkAudio) {
                walkAudio.Pause();
                isPlayingWalkAudio = false;
            }
            GetComponent<Animator>().SetBool("walk", false);
        }
    }
}
