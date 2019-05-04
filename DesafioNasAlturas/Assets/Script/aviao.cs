using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aviao : MonoBehaviour
{
    Rigidbody2D fisica;

    
    private void Awake()
    {
        //Debug.Log("Acordei");
        this.fisica = this.GetComponent<Rigidbody2D>();
    }
    
    private void impulsionar()
    {
        this.fisica.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
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
