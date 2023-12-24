using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class story : MonoBehaviour
{
    public Image image;
    public Scrollbar scrollbar;
    [SerializeField] float scrollSpeed = 0.4f;
    public Canvas storyCanvs;
    [SerializeField] private GameObject[] btn;
    public bool isAnimating = false;
    public bool isAnimated = false;
    private float screenHeight;
    private float maxY;
    [SerializeField] private Player player;

    void Start() {
        screenHeight = storyCanvs.GetComponent<RectTransform>().rect.height;
        maxY  = image.rectTransform.rect.height - screenHeight + image.rectTransform.anchoredPosition.y;
        scrollbar.value = 0f;
        scrollbar.gameObject.SetActive(false);
        foreach(GameObject go in btn) {
            go.SetActive(false);
        }
        if (isAnimating) {
            isAnimating = false;
            Invoke("delay1", 3f);
        }
        if (isAnimated) {
            scrollbar.value = 0f;
        }
    }

    private void delay1() {
        isAnimating = true;
    }

    [SerializeField] private float playingSpeed = 30f;
    void Update() {
        if (isAnimating) {
            image.rectTransform.anchoredPosition += new Vector2(0f, Time.deltaTime * playingSpeed);
            player.isMove = false;
            if (image.rectTransform.anchoredPosition.y >= maxY) {
                isAnimated = true;
                isAnimating = false;
                scrollbar.gameObject.SetActive(true);
                foreach(GameObject go in btn) {
                    go.SetActive(true);
                }
                scrollbar.value = 1f;
            }
        }
        else {
            float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
            scrollbar.value += scrollWheel * scrollSpeed * -1;

            float keyboardInput = Input.GetAxis("Vertical");
            scrollbar.value += keyboardInput * scrollSpeed * Time.deltaTime * -1;

            scrollbar.value = Mathf.Clamp01(scrollbar.value);
        }
    }

    public void OnScrollbarValueChanged() {
        if(!isAnimating) {
            float transValue = scrollbar.value * 2 - 1;
            float targetY = maxY * transValue;
            image.rectTransform.anchoredPosition 
            = new Vector2(image.rectTransform.anchoredPosition.x, targetY);
        }
    }
}
