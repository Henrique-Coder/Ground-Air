using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lava : MonoBehaviour
{
    [SerializeField]private string Cena;

    void OnTriggerEnter2D(Collider2D lavareset){
        if(lavareset.gameObject.tag == "PlayerCloud"){
            SceneManager.LoadScene(Cena);
        }
    }
    public void heatdestroy(){
        if(gameObject.tag == "Heat"){
        Destroy(gameObject);
        }
    } 
}
