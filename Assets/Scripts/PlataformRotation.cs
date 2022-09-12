using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlataformRotation : MonoBehaviour
{
    public string Cena;
   Vector3 a;
    float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        a.x = 0.0f;
        a.y = 0.0f;
        a.z = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
            Rotaçao(a);
    }
    void Rotaçao(Vector3 a)
    {
        transform.Rotate(a);
    }

    void OnCollisionEnter2D(Collision2D plataform){
        if(plataform.gameObject.tag == "PlayerGround" || plataform.gameObject.tag == "PlayerCloud"){
            SceneManager.LoadScene(Cena);
        }
    }
}
