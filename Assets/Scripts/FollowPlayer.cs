using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Global
    public GameObject player;
    private Vector3 relativePosition = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Camera moves Relative to the vehicle's position
        transform.position = player.transform.position + relativePosition;
    }
}
