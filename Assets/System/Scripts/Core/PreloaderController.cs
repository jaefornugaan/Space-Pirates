using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreloaderController : MonoBehaviour
{
    private void Start()
    {
        Game.LoadScene("loader", .5f);
    }
}
