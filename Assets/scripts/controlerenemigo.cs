using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlerenemigo : MonoBehaviour
{
    public float velocidadEnemigo = 1f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,new Vector2(player.position.x,transform.position.y),velocidadEnemigo*Time.deltaTime);
    }
}
