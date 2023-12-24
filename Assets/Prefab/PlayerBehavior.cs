using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Player player;
    
   private void Start() {
        rb = GetComponent<Rigidbody2D>();
        player.isMove = true;
    }

    public bool isPlayingOtherAnim = false;
    private void Update() {
        if(isPlayingOtherAnim) return;
        if(!player.isMove) {
            GetComponent<Animator>().SetBool("walk", false);
            rb.velocity = new Vector2(0, 0).normalized * moveSpeed;
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
            GetComponent<Animator>().SetBool("walk", true);
        }
        else {
            GetComponent<Animator>().SetBool("walk", false);
        }
    }
}
