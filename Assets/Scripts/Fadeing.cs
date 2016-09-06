using UnityEngine;
using System.Collections;

public class Fadeing : MonoBehaviour
{
    public Animator animator;

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();   
    }
    
    void Update()
    {
        fadeText();
    }

    public void fadeText()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("upKeyPressed", true);
        }
    }

}
