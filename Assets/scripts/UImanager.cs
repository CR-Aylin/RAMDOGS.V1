using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    private int Total;
    [SerializeField]private TMP_Text textomonedas;

    private void Star(){
        Moneda.sumaMoneda += SumarMonedas;
    }

    private void SumarMonedas(int moneda){

        Total += moneda;
        textomonedas.text= Total.ToString();

    }
}
