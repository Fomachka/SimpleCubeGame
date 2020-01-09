using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    //set up camera behind our object to follow
    public Vector3 offsetCameraView;

    // Update is called once per frame
    void Update()
    {
        
        transform.position = player.position + offsetCameraView;
    }
}
