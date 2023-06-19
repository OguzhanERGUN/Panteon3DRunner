using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCollision : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI coinText;
    public float boostSpeedValue;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Booster"))
        {
            StartCoroutine(GetBoost());
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    IEnumerator GetBoost()
    {
        FindObjectOfType<PlayerController>().runningSpeed += boostSpeedValue;
        yield return new WaitForSeconds(3f);
        FindObjectOfType<PlayerController>().runningSpeed -= boostSpeedValue;

    }

    private void AddCoin()
    {
        score++;
        coinText.text = "Score: " + score;
    }
}
