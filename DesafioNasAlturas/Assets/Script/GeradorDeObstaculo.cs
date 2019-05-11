using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculo : MonoBehaviour
{

    [SerializeField]
    private float tempoParaGerar = 3f;

    [SerializeField]
    private GameObject manualDeInstrucoes;

    private float cronometro = 0f;

    void Awake()
    {
        cronometro = tempoParaGerar;
    }


    void Update()
    {
        cronometro -= Time.deltaTime;

        if(cronometro <= 0)
        {
            //Debug.Log("3 segundo");
            // Debug.Log(Quaternion.identity);
            GameObject.Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}
