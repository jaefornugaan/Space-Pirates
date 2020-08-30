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
    public GameView view;
    public bool bIsLodingScene = false;

    public void LoadScene(string sceneName, float delay = .25f)
    {
        StartCoroutine(IELoadScene(sceneName, delay));
    }

    private IEnumerator IELoadScene(string sceneName, float delay)
    {
        yield return new WaitForSeconds(0.1f);

        if (bIsLodingScene)
        {
            Debug.Log("Ya se esta cargando una escena.");
            yield break;
        }
        else
        {
            bIsLodingScene = true;
        }

        view.FadeInScreen(delay);
        yield return new WaitForSeconds(delay);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while (!operation.isDone)
        {
            yield return null;
        }

        bIsLodingScene = false;
    }
}
