using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BoxRotate : MonoBehaviour
{

    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Rotate(rotation);
        }
        
    }
}
