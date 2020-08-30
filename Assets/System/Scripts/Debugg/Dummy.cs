using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;

    public void Tick(float d)
    {
        Debug.Log("Actualizo");
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, d* speed);
    }
}
