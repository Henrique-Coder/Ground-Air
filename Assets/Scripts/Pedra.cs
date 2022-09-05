using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedra : MonoBehaviour
{
    private Rigidbody2D RB2D;
    private BoxCollider2D boxCollider2d;
    Vector2 mov;
    float jumpvel;
    [SerializeField] private LayerMask platformLayerMask;
    // Start is called before the first frame update
    void Start()
    {
        mov.x = 0.0f;
        mov.y = 0.0f;
        jumpvel = 0.0f;
        RB2D = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
        if(Input.GetKey(KeyCode.UpArrow) && IsGrounded()){
            jumpvel = 5f;
            RB2D.velocity = Vector2.up * jumpvel;
        }
    }
    void Andar(Vector2 mov){
        transform.Translate(mov);
    }

    private bool IsGrounded() {
        float check = 0.1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, check, platformLayerMask);

        Color rayColor;
        if (raycastHit.collider != null) {
            rayColor = Color.green;
        } else {
            rayColor = Color.red;
        }
        return raycastHit.collider != null;
    }

    public void DestroirPedra(){
        Destroy(gameObject);
    }
}
