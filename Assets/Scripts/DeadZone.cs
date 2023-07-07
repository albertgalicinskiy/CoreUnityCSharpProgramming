using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col) 
    {
        col.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    void OnTriggerExit(Collider col) 
    {
        col.gameObject.GetComponent<Renderer>().material.color = Color.green;    
    }

    void OnTriggerStay(Collider col) 
    {
    
    }
}
