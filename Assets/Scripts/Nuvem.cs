using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuvem : MonoBehaviour
{
    Vector2 mov;
    private bool parado;
    // Start is called before the first frame update
    void Start()
    {
        mov.x = 0.0f;
        mov.y = 0.0f;
        parado = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            mov.x = 0.01f;
            Voar(mov);
            mov.x = 0.0f;
            parado = false;
            transform.localScale = new Vector2(1, 1);
            GetComponent<Animator>().SetBool("Airidle", false);
        }
        if(Input.GetKey(KeyCode.A)){
            mov.x = -0.01f;
            Voar(mov);
            mov.x = 0.0f;
            parado = false;
            transform.localScale = new Vector2(-1, 1);
            GetComponent<Animator>().SetBool("Airidle", false);
        }
        if(Input.GetKey(KeyCode.W)){
            mov.y = 0.01f;
            Voar(mov);
            mov.y = 0.0f;
            GetComponent<Animator>().SetBool("Airidle", true);
        }
        if(Input.GetKey(KeyCode.S)){
            mov.y = -0.01f;
            Voar(mov);
            mov.y = 0.0f;
            GetComponent<Animator>().SetBool("Airidle", true);
        }
        if(parado){
            GetComponent<Animator>().SetBool("Airidle", true);
        }
        if(mov.x == 0 || mov.y == 0){
            parado = true;
        }
    }
        void Voar(Vector2 mov){
        transform.Translate(mov);

    }
        public void DestroirNuvem(){
            if(gameObject != null){            
            Destroy(gameObject);
            }
        }
}
