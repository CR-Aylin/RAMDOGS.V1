using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermov : MonoBehaviour
{
    // declaro variable para ajustar velocidad del jugador
    [SerializeField]private float speed = 3f;
    // referencia al rigibody
    private Rigidbody2D Playerpipipi;
    private Vector2 moveInput;

    private Animator animacionplayer;


    void Start()
    {
        //obtener ref//citar
        Playerpipipi = GetComponent<Rigidbody2D>();
        animacionplayer = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxisRaw("Horizontal"); //valor -1 o 1
        float movY = Input.GetAxisRaw("Vertical"); //valor -1 o 1
        moveInput = new Vector2(movX,movY).normalized;

        animacionplayer.SetFloat("Horizontal",movX);
        animacionplayer.SetFloat("Vertical",movY);
        animacionplayer.SetFloat("speed",moveInput.sqrMagnitude);
    }

    private void FixedUpdate(){// Fisicas
    // mover atraves de rigidbody
    //posicion actual + mov dado por entradas y controlar velocidad 

    Playerpipipi.MovePosition(Playerpipipi.position + moveInput * speed * Time.fixedDeltaTime);
    


    }

}
