using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Waiting,
    InMenu,
    Playing
}

public class GameController : Singleton<GameController>
{
    public GameState state;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
