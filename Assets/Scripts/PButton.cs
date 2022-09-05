using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PButton : MonoBehaviour
{
    [SerializeField] private Transform PlataformPrefab;
    [SerializeField] private GameObject PlataformSpawn;


    void OnTriggerEnter2D(Collider2D plataformbutton){
        if(plataformbutton.gameObject.tag == "PlayerCloud"){
            Instantiate(PlataformPrefab,PlataformSpawn.transform.position , Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
