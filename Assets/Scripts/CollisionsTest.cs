using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) // col will store what the object is colided
    { 
        
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }  

    }

}
