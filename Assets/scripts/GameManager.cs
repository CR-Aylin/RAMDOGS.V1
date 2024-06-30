using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PuntosTotales{ get{return puntostotales;}}
    private int puntostotales;
   public void SumarPuntos(int puntosASumar){
    puntostotales += puntosASumar;
    // imprime consola
    //Debug.Log(PuntosTotales);
   }
}
