using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private Rigidbody2D rb;
    

   private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
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

        // if(Input.GetKeyDown(KeyCode.B)) {
        //     GameManager.GetComponent<GameManager>().OpenBackpack();
        // }

        // if(Input.GetKeyDown(KeyCode.Escape)) {
        //     GameManager.GetComponent<GameManager>().CloseBackpack();
        // }

        // if(Input.GetKeyDown(KeyCode.Q)) {
        //     GameManager.GetComponent<GameManager>().switchScene();
        // }
    }
}
