using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public bool cloudR;
    public bool groundR;
    public string Cena;
    void Start(){
        cloudR = false;
        groundR = false;
    }
    void Update(){
        if(cloudR && groundR){
        SceneManager.LoadScene(Cena);
        }
    }
    void OnTriggerEnter2D(Collider2D win){
        if(win.gameObject.tag == "PlayerCloud"){
            cloudR = true;
        }
        if(win.gameObject.tag == "PlayerGround"){
            groundR = true;
        }
    }
    void OnTriggerExit2D(Collider2D notwin){
        if(notwin.gameObject.tag == "PlayerCloud"){
            cloudR = false;
        }
        if(notwin.gameObject.tag == "PlayerGround"){
            groundR = false;
        }
    
    }
}
