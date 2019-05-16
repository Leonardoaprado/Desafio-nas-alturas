using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aviao : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float força = 10f;

    [SerializeField]
    private Diretor diretor;

    private Vector3 posicaoInicial;
    
    
    private void Awake()
    {
        //Debug.Log("Acordei");
        this.fisica = this.GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<Diretor>();
        posicaoInicial = this.transform.position;
    }

    public void Reiniciar()
    {
        this.transform.position = posicaoInicial;
        this.fisica.simulated = true;
    }
    
    private void impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * força, ForceMode2D.Impulse);
    }


    void OnCollisionEnter2D(Collision2D Colisao)
    {
        fisica.simulated = false;
        diretor.FinalizarJogo();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("clicou");
            impulsionar();
        }
    }
}
