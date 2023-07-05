using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTest : MonoBehaviour
{

    public float speed;

    //Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {

        // int x = 5;
        // x = x + 5; // 10
        // x += 5

    //    pos = new Vector3(1f, 2f, 3f); // (x, y, z) 
    //    print(pos.x);

        // print(transform.position); // print current position of the elenent that this script to attached

        // transform.position = new Vector3(0, 0, 0);  // change postion

        //transform.position += new Vector3(1f, 0, 0); 
        // the same as above - transform.position = transform.position + new Vector3(1f, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += new Vector3(0, 0.01f, 0);

        // it's better to use
        // transform.position += transform.up * speed; // (0, 1, 0)
        // transform.position += transform.right * speed; // (1, 0, 0)
        // transform.position += transform.forward * speed; // (0, 0, 1)

        transform.Translate(speed, 0, 0); // (x, y, z) - move object easily without doing all things above

        transform.Rotate(0, speed, 0); // чтобы вращать объект

        // transform.localScale += new Vector3(0, speed, 0);
        // the same as above
        // transform.Rotate(speed, 0, 0);
        transform.localScale += transform.up * speed;
    }
}
