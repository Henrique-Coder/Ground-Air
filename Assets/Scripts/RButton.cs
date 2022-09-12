using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RButton : MonoBehaviour
{
    [SerializeField] private GameObject RPlataform;
    [SerializeField] private PlataformRotation rotationscript;

    void OnTriggerEnter2D(Collider2D gira){
        if(gira.GetComponent<BoxCollider2D>() != null){
            rotationscript.enabled = false;
        }
    }
    void OnTriggerExit2D(Collider2D voltagira){
        if(voltagira.GetComponent<BoxCollider2D>() != null){
            rotationscript.enabled = true;
        }
    }
}
