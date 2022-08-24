using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerControllerX : MonoBehaviour
{
    //Global Vars
    private float propSpeed = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spin Propeller
        transform.Rotate(Vector3.forward * propSpeed * Time.deltaTime);
    }
}
