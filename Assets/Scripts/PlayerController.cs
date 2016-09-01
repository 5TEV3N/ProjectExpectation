using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float mouseSensitivity = 1;    //mouse sensitivity
    public float playerSpeed = 1;  //We can controll the speed of the player here.
    public Rigidbody rb;
    public Camera cam;  //A reference to the attached camera ! be sure to actually but the camera object from the scene into the script @ the inspector window
    
    public void Mouselook(float mouseXAxis, float mouseYAxis)
    {
        // rotate the player charecter on the y axis to look left or right. This is done so that you dont fuck up the camera up
        transform.Rotate(0, mouseXAxis * mouseSensitivity, 0);
        // rotate the camera on the x axis to look up and down.
        //cam.transform.Rotate(-mouseYAxis * mouseSensitivity, 0, 0);
    }

    public void PlayerMove(float xAxis, float zAxis)
    {
        if (xAxis != 0)
        {
            if (xAxis > 0)
            {
                //positive x = Right
                rb.AddForce(transform.right * playerSpeed);
            }

            if (xAxis < 0)
            {
                rb.AddForce(-transform.right * playerSpeed);
            }
        }

        if (zAxis != 0)
        {
            if (zAxis > 0)
            {
                //positive z = Forward
                rb.AddForce(transform.forward * playerSpeed);
            }

            if (zAxis < 0)
            {
                rb.AddForce(-transform.forward * playerSpeed);
            }
        }

    }

}