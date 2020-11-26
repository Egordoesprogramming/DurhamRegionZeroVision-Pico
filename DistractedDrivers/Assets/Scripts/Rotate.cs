using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
   
   void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
       
        var speed = 10;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }

      

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
        }

       
    }
}
