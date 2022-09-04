using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    public float speed;
    public int currentpoint;
    public Transform[] pointdestination;
    public bool buttonpressed;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        buttonpressed = false;
        transform.position = pointdestination[currentpoint].position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, pointdestination[i].position) < 0.02f){
            i++;
            if(i == pointdestination.Length){
                i = 0;
            }
        }
    }

    public void Working(){
        transform.position = Vector2.MoveTowards(transform.position, pointdestination[i].position, speed * Time.deltaTime);
    }
}
