using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.2f;


    void Update()
    {
        transform.Translate(Vector3.left * velocidade);
    }
}
