using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderController : MonoBehaviour
{
    private void Start()
    {
        Game.LoadScene("MainMenu", .5f);
    }
}
