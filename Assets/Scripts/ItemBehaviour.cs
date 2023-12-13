using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour {

    [SerializeField] private GameObject GameManager;
    [SerializeField] private GameObject ItemsIcon;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            GameManager.GetComponent<GameManager>().AddGottenItem(ItemsIcon);
        }
        gameObject.SetActive(false);
    }
}
