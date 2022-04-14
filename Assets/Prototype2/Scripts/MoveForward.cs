using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField]
    private float speed;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * (speed*Random.Range(1f,2f)));

    }
}
