using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    public UnityEvent onPickUpCollison;
    
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    public void Move(Vector3 movement)
    {        
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up")){
            other.gameObject.SetActive(false);
            onPickUpCollison.Invoke();
        }
    }
}

