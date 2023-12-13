using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private static PlayerBehaviour instance;
    private void Awake()
    {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject GameManager;

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

        if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Return)) {
            GameManager.GetComponent<GameManager>().NextDialogContent();
        }

        if(Input.GetKeyDown(KeyCode.B)) {
            GameManager.GetComponent<GameManager>().OpenBackpack();
        }

        if(Input.GetKeyDown(KeyCode.Escape)) {
            GameManager.GetComponent<GameManager>().CloseBackpack();
        }

        if(Input.GetKeyDown(KeyCode.Q)) {
            GameManager.GetComponent<GameManager>().switchScene();
        }
    }

}
