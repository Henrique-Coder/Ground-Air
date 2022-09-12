using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TButton : MonoBehaviour
{
    [SerializeField] private GameObject TM;
    [SerializeField] private TMenor tetomovelscript;
    
    // Start is called before the first frame update
    void Start(){

    }
    void OnTriggerEnter2D(Collider2D teto){
        if(teto.gameObject.tag == "PlayerGround"){
            tetomovelscript.mudarescala();
            Destroy(gameObject);
        }
    }
}
