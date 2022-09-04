using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EButton : MonoBehaviour
{
    [SerializeField] private GameObject Elevator;
    [SerializeField] private Elevador elevatorscript;
    // Start is called before the first frame update
    void Start()
    {
        elevatorscript = Elevator.GetComponent<Elevador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collider){
        if(collider.GetComponent<BoxCollider2D>() != null){
            elevatorscript.Working();
        }
    }
}
