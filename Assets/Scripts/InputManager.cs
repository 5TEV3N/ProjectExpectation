using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    PlayerController playerController;
    float xAxis = 0; // 1 = right, -1 = left
    float zAxis = 0; // 1 = front, -1 back
    float mouseXAxis = 0; // left or right movement of mouse (camera). Positive numb = right, Negative numb = left
    float mouseYAxis = 0; // up or down movement of mouse (camera). Positive numb = up, Negative numb = down.

    void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<PlayerController>();
    }

    void Update()
    {
        mouseXAxis = Input.GetAxis("Mouse X");
        mouseYAxis = Input.GetAxis("Mouse Y");
        if (mouseXAxis != 0 || mouseYAxis != 0)
        {
            playerController.Mouselook(mouseXAxis, mouseYAxis);
        }

        xAxis = Input.GetAxisRaw("Horizontal");
        zAxis = Input.GetAxisRaw("Vertical");
        if (xAxis != 0 || zAxis != 0)
        {
            playerController.PlayerMove(xAxis, zAxis);
        }
    }
}
