using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diploma : MonoBehaviour
{
    public GameObject winUI;
    public GameObject pauseButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            winUI.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
