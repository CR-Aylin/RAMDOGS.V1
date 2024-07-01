using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playermov2 : MonoBehaviour
{   
    public float velocidad = 1;
    public float salto = 2;

 
    
    Rigidbody2D player;
    Animator animacionplayer;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animacionplayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.D)){ // mov player derecha

       player.velocity = new Vector2(velocidad,player.velocity.y);
       animacionplayer.SetBool("camid",true);
       animacionplayer.SetBool("camiz",false);
       

       }else if (Input.GetKey(KeyCode.A)){//mov player izq

        player.velocity = new Vector2(-velocidad,player.velocity.y);
        animacionplayer.SetBool("camid",false);
        animacionplayer.SetBool("camiz",true);
        

       }else{
        animacionplayer.SetBool("camid",false);
        animacionplayer.SetBool("camiz",false);
       }

       if(Input.GetKey(KeyCode.W)){ // player salto

        player.velocity = new Vector2(player.velocity.x,salto);      

       }
    }
    

    
}
