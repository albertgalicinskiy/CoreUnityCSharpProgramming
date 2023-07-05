using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{

    GameObject searchObj; // if I want to do something with object I have to store it in variables

    GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        /* Search using element name

        // searchObj = GameObject.Find("Sphere"); // find object in Unity
        searchObj = GameObject.Find("Cube/Cube2/Enemy"); // find object inside another object
        Destroy(searchObj);

        */

        // Search using element with Tag 
        
        
        // searchObj = GameObject.FindWithTag("Enemy"); // Destroy only one tagged element

        // enemies = GameObject.FindGameObjectsWithTag("Enemy");

        /*
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy); // Destroy all elements with tag Enemy one by one
        }
        */
        GameObject.Find("Cube").SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
