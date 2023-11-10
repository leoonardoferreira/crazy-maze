using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public Text timeText;
    private float elapsedTime = 3600f;  // Inicia o tempo em 90 segundos
    public GameObject gameOverPanel;  // Painel de Game Over
    public Text gameOverText;  // Texto de Game Over

    // Start is called before the first frame update
    void Start()
    {
        UpdateTimeText();
        gameOverPanel.SetActive(false);  // Inicia o painel de Game Over como desativado
    }

    // Update is called once per frame
    void Update()
    {
        
        elapsedTime -= Time.deltaTime; 

        if (elapsedTime <= 0)
        {
            elapsedTime = 0;
            GameOver();
        }

        int minutes = Mathf.FloorToInt(elapsedTime) / 60;
        int seconds = Mathf.FloorToInt(elapsedTime) % 60;
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void UpdateTimeText()
    {
        timeText.text = elapsedTime.ToString("F2");
    }

    void GameOver()
    {
        // Ativar o painel de Game Over
        gameOverPanel.SetActive(true);
        // Definir o texto de Game Over com cor vermelha
        gameOverText.text = "Game Over!";
        gameOverText.color = Color.red;
        // Adicione aqui lógica adicional de Game Over, se necessário.
    }
}
