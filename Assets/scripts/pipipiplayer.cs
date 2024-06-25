using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipipiplayer : MonoBehaviour
{
    [SerializeField]private float velocidad;

    private Rigidbody2D rig;

    private void awake(){

        rig = GetConponent<Rigidbody2D>();

        private void FixedUpdate(){
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            rig.velocity = new vector2(horizontal,vertical)*velocidad;
        }
    }
   
}
