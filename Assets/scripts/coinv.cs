using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class coinv : MonoBehaviour
{
    public int valor = 100;
    public GameManager gameManager;
    

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.CompareTag("Player")){
            gameManager.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
    }
}
