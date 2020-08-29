using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Game
{
    
    public static void LoadScene(string sceneName)
    {
        controller.LoadScene(sceneName);
    }

    public static GameController controller 
    {
        get
        {
            return GameController.Instance;
        }
    }
}
