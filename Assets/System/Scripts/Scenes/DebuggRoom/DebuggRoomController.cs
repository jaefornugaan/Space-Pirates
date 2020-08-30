using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggRoomController : MonoBehaviour
{
    public List<Dummy> dummies = new List<Dummy>();
    public float delta;

    private void Start()
    {
        Game.FadeOutScreen(.5f);
    }

    private void Update()
    {
        delta = Time.deltaTime;
        if (dummies.Count > 0)
        {
            for (int i = 0; i < dummies.Count; i++)
            {
                dummies[i].Tick(delta);
            }
        }
        
    }
}
