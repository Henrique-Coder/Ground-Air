using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TButton : MonoBehaviour
{
    [SerializeField] private Transform TetoDiminuido;
    [SerializeField] private GameObject TetoAtual;
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D teto){
        if(teto.gameObject.tag == "PlayerGround"){
            Destroy(TetoAtual);
            Instantiate(TetoDiminuido, new Vector2(-1.18f, 1.642f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
