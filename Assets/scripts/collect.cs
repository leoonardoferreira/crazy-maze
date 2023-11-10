using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C : MonoBehaviour
{

    
    private int Score = 0;
    public Text scoreText; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Score"))
        {
            Score++; // Incrementa a pontua��o em 1. 
            

            scoreText.text = "Score: " + Score.ToString(); // Atualiza o texto da pontua��o.
            Debug.Log(Score);
            Destroy(other.gameObject);
        }
    }
}
