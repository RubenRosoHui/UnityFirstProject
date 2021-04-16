using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    //stores 3 floats
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
