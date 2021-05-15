using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform playerTransform;
    private Vector3 eulerAngles;
    void Start ()
    {
        eulerAngles = transform.eulerAngles;
        playerTransform = transform;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            Debug.Log("FIRING");
        }

        
        playerTransform.eulerAngles = new Vector3(eulerAngles.x+(Input.GetAxis("JoystickX")*50), eulerAngles.y+(Input.GetAxis("JoystickY")*50), eulerAngles.z+(Input.GetAxis("JoystickZ")*50));
        
    }
}
