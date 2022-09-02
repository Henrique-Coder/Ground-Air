using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedra : MonoBehaviour
{
    public Transform GroundCheck;
    public bool isGrounded;
    Vector2 mov;
    // Start is called before the first frame update
    void Start()
    {
        mov.x = 0.0f;
        mov.y = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.Linecast(transform.position, GroundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }
        if(Input.GetKey(KeyCode.RightArrow)){
            mov.x = 0.01f;
            Andar(mov);
            mov.x = 0.0f;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            mov.x = -0.01f;
            Andar(mov);
            mov.x = 0.0f;
        }
        if(Input.GetKey(KeyCode.UpArrow) && isGrounded){
            mov.y = 0.01f;
            Andar(mov);
            mov.y = 0.0f;
        }
    }
    void Andar(Vector2 mov){
        transform.Translate(mov);
    }
}
