using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HuD : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI puntos;
        void Update()
    {
        puntos.text = gameManager.PuntosTotales.ToString();
    }
}
