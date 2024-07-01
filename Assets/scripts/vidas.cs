using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class vidas : MonoBehaviour
{
  public GameObject[] vida;

  public void desactivarvida(int indice){
    vida[indice].SetActive(false);
  }

  public void activarvida(int indice){
    vida[indice].SetActive(true);
  }
}
