using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LButton : MonoBehaviour
{
    [SerializeField] private Transform LavaPlataform;
    [SerializeField] private GameObject LavaPlataformSpawn;
    [SerializeField] private Lava Lavascript;
    void OnTriggerEnter2D(Collider2D lavabutton){
        if(lavabutton.gameObject.tag == "PlayerGround"){
            Instantiate(LavaPlataform, LavaPlataformSpawn.transform.position, Quaternion.identity);
            Destroy(gameObject);
            Lavascript.heatdestroy();
        }

    }
}
