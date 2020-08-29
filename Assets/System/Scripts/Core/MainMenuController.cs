using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    private void Start()
    {
        Game.controller.state = GameState.InMenu;
    }
}
