using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public UnityEvent onTreasureFound;
    public UnityEvent onCaught;

    
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    public void Move(Vector3 movement)
    {        
        rb.velocity = movement * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Treasure")){
            onTreasureFound.Invoke();
        } else if(other.gameObject.CompareTag("Guard")){
            onCaught.Invoke();
        }
    }
}
