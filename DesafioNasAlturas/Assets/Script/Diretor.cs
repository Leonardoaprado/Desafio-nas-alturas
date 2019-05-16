using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public GameObject ImagemGamerOver;

    [SerializeField]
    private aviao aviao;


    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        ImagemGamerOver.SetActive(true);
        Debug.Log("Acabou");
    }

    void Start()
    {
        aviao = GameObject.FindObjectOfType<aviao>();
    }
    public void ReiniciarJogo()
    {

        ImagemGamerOver.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("Reiniciou");
        aviao.Reiniciar();
        DestruirObstaculos();

    }
    private void DestruirObstaculos()
    {
        Obstaculos[] obstaculosEncontrados = GameObject.FindObjectsOfType<Obstaculos>();
        foreach (Obstaculos obstaculoAtual in obstaculosEncontrados)
        {
            obstaculoAtual.Destruir();
        }
    }
}