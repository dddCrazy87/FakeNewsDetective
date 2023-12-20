using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStart : MonoBehaviour
{
    [SerializeField] private GameObject player, point1, point2;
    [SerializeField] private float queen_moveSpeed = 4f;
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private GameObject map, ins_mis;
    private Rigidbody2D rb;
    private bool toStop = false, playerToMove = false;
    private float moveX = 0f, moveY = 0f;
    void Start() {
        if(instructionAndMission.instructionID < 9) {
            player.transform.position = new Vector3(-8.22f, 0f, 0f);
            Destroy(gameObject);
        }
        else {
            map.SetActive(false);
            ins_mis.SetActive(false);
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            player.GetComponent<Rigidbody2D>().freezeRotation = true;
            rb = GetComponent<Rigidbody2D>();
            rb.freezeRotation = true;
            Invoke("toStart", 1f);
        }
    }

    private void toStart() {
        moveX = 1f;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Qixing_point1") {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.freezeRotation = true;
            toStop = true;
            Invoke("toWalk", 2f);
        }
        if(other.gameObject.tag == "Qixing_point2") {
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            player.GetComponent<Rigidbody2D>().freezeRotation = true;
            Invoke("playerToWalk", 1f);
        }
    }

    private void playerToWalk() {
        playerToMove = true;
    }

    private void toWalk() {
        rb.constraints = RigidbodyConstraints2D.None;
        rb.freezeRotation = true;
        moveY = -2f;
        toStop = false;
    }

    private void Update() {
        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement.normalized * queen_moveSpeed;
        if(toStop) {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        if(playerToMove) {
            player.transform.position = Vector2.Lerp(player.transform.position, new Vector2(-8.22f,0f), Time.deltaTime * 2f);
            Invoke("bye", 2f);
        }
    }

    private void bye() {
        Destroy(point1);
        Destroy(point2);
        map.SetActive(true);
        ins_mis.SetActive(true);
        Destroy(gameObject);
    }
}
