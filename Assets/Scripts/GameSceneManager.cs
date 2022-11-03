using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    // Funciones para acceder a distintas escenas.

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToIntroduction()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void GoToBriefing()
    {
        SceneManager.LoadScene("Briefing");
    }

    public void GoToGameplay()
    {
        SceneManager.LoadScene("MainScene");
    }

    // Función que nos permite salir del juego.
    public void ExitGame()
    {
      Application.Quit();
    }

}

