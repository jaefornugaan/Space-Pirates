using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }
    public bool dontdestroyOnLoad;

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("A instance already exists");
            Destroy(this.gameObject); //Or GameObject as appropriate
            return;
        }
        Instance = this as T;
        if (dontdestroyOnLoad)
            DontDestroyOnLoad(gameObject);

        gameObject.SetActive(gameObject.activeSelf);
 
    }

}
