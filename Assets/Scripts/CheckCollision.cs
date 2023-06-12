using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);
        }
    }




    private void AddCoin()
    {
        score++;
        coinText.text = "Score: " + score;
    }
}
