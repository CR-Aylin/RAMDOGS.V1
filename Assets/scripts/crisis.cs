using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crisis : MonoBehaviour
{
    Animator animacionplayer;
    // Start is called before the first frame update
    void Start()
    {
        animacionplayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   //boto pa probar

   [ContextMenu("boton")]
    public void CambiarNivel(){

        animacionplayer.SetBool("llora",true);
        Invoke("tiempo",5);
        /*
        int actaul = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(2);
        */
        
        //SceneManager.LoadScene(2);
    }

    public void OnCollisionEnter(Collision collision){

        if(collision.gameObject.CompareTag("crisis")){

        Debug.Log("Crisis");
        int actaul = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(actaul + 1);

        }
    }
    public void tiempo(){
        int actaul = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(2);
    }

    
}
