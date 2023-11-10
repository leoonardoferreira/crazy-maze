using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour

{
    [SerializeField] private string nomeDoLevel;
    public void Play()
    {
        SceneManager.LoadScene(nomeDoLevel);
    }

    public void Exit()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}