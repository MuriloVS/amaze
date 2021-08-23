using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // só para debugar - deve aparecer um zero
    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }

    public void PlayGame()
    {   
        // remover o comentário abaixo ao criar a nova cena
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
