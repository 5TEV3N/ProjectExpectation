using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float mouseSensitivity = 1;    //mouse sensitivity
    public float playerSpeed = 1;  //We can controll the speed of the player here.
    public Rigidbody rb;

    public void Mouselook(float mouseXAxis, float mouseYAxis)
    {
        //Filter vertical input
        if (mouseXAxis != 0)
        {
            gameObject.transform.Rotate(new Vector3(0, mouseXAxis, 0));
        }

        //Filter horizontal input
        if (mouseYAxis != 0)
        {
            gameObject.transform.Rotate(new Vector3(-mouseYAxis, 0, 0));
        }

        if (gameObject.transform.localRotation.z != 0)
        {
            //localEulerAngles = Actual angle objet is rotated to in local space
            Vector3 myVec = gameObject.transform.localEulerAngles;
            gameObject.transform.localEulerAngles = new Vector3(myVec.x, myVec.y, 0);
        }
        
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