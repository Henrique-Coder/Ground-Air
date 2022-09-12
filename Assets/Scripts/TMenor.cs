using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMenor : MonoBehaviour
{
    public Vector2 tetomenor;
    public Vector2 tetomenorpos;

    public void mudarescala(){
        transform.localScale = tetomenor;
        transform.position = tetomenorpos;
    }
}
