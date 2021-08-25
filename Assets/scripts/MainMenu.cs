using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // para debugar - deve aparecer um zero
    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }

    public void PlayGame()
    {
        Debug.Log("Play clicked");

        // remover o comentario abaixo ao criar a nova cena
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
