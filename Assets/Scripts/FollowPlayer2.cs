using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    // Variables
    public GameObject player;
    private Vector3 offsetThirdPerson = new Vector3(0, 5, -7);
    private Vector3 offsetFirstPerson = new Vector3(0, 2, 1);
    private bool cameraThirdPerson = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the Right Shift key is pressed
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            if (cameraThirdPerson == true)
            {
                // If in third person, change the camera to first person
                cameraThirdPerson = false;
            }
            else
            {
                // If in first person, change the camera to third person
                cameraThirdPerson = true;
            }
        }
        // If no key is pressed, refresh camera as is
        else
        {
            if (cameraThirdPerson == true)
            {
                // Change the camera to third person
                transform.position = player.transform.position + offsetThirdPerson;
            }
            else
            {
                // Change the camera to first person
                transform.position = player.transform.position + offsetFirstPerson;
            }
        }
    }
}
