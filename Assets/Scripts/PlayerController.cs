using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Global Variables
    private float vehSpeed = 15.0f;
    private float turnSpeed = 20.0f;
    private float horizontalShiftInput;
    private float verticalShiftInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move Vehicle Forward
        verticalShiftInput = Input.GetAxis("Vertical"); //Get Vertical Axis Input
        transform.Translate(Vector3.forward * verticalShiftInput * vehSpeed * Time.deltaTime);

        //Turning vehicle
        horizontalShiftInput = Input.GetAxis("Horizontal"); //Get Horizontal Axis Input
        transform.Rotate(Vector3.up, horizontalShiftInput * turnSpeed * Time.deltaTime);
        //Slide //transform.Translate(Vector3.right * horizontalShiftInput * shiftSpeed * Time.deltaTime);
    }
}
