using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 cameraOffset = new Vector3(30, 0, 6);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Position Camera adjacent to Player
        transform.position = plane.transform.position + cameraOffset;
    }
}
