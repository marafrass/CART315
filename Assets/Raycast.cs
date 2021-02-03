using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    public Camera maincamera;
    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        { 
        
        

            Debug.Log("Clicked");

            Ray clickray = maincamera.ViewportPointToRay(Input.mousePosition);
            RaycastHit result;
            if (Physics.Raycast(clickray, out result))
            {
                GameObject.Instantiate(prefab, result.point, Quaternion.identity);

            }
               
        
        }
    }
}
