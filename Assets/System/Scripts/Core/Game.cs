using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Game
{
    
    public static void LoadScene(string sceneName, float delay = 0.25f)
    {
        controller.LoadScene(sceneName, delay);
    }

    public static void FadeInScreen(float time = .25f)
    {
        controller.view.FadeInScreen(time);
    }

    public static void FadeOutScreen(float time = .25f)
    {
        controller.view.FadeOutScreen(time);
    }

    public static GameController controller 
    {
        get
        {
            return GameController.Instance;
        }
    }
}
