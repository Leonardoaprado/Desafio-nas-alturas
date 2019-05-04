using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aviao : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float força = 10;
    
    private void Awake()
    {
        //Debug.Log("Acordei");
        this.fisica = this.GetComponent<Rigidbody2D>();
    }
    
    private void impulsionar()
    {
        this.fisica.AddForce(Vector2.up * força, ForceMode2D.Impulse);
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
