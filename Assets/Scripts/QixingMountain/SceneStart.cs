using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStart : MonoBehaviour
{
    [SerializeField] private GameObject player, point1, point2, walls;
    [SerializeField] private float queen_moveSpeed = 4f;
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private GameObject map, ins_mis;
    private Rigidbody2D rb;
    private bool toStop = false, playerToMove = false;
    private float moveX = 0f, moveY = 0f;
    void Start() {
        if(instructionAndMission.instructionID < 9) {
            walls.SetActive(true);
            player.transform.position = new Vector3(-8.22f, 0f, 0f);
            Destroy(gameObject);
        }
        else {
            map.SetActive(false);
            ins_mis.SetActive(false);
            player.SetActive(false);
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
            Invoke("playerToWalk", 1f);
        }
    }

    private void playerToWalk() {
        player.SetActive(true);
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
            player.GetComponent<PlayerBehavior>().isPlayingOtherAnim = true;
            player.GetComponent<Animator>().SetBool("walk", true);
            player.transform.position = Vector2.Lerp(player.transform.position, new Vector2(-7f,0f), Time.deltaTime * 2.5f);
            Invoke("bye", 2f);
        }
    }

    private void bye() {
        player.GetComponent<PlayerBehavior>().isPlayingOtherAnim = false;
        player.GetComponent<Animator>().SetBool("walk", false);
        Destroy(point1);
        Destroy(point2);
        map.SetActive(true);
        ins_mis.SetActive(true);
        walls.SetActive(true);
        Destroy(gameObject);
    }
}
