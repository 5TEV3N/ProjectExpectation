using UnityEngine;
using System.Collections;

public class Fadeing : MonoBehaviour
{
    public Animator animator;

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();   
    }

    public void fadeUp()
    {
        animator.SetBool("upKeyPressed", true);
    }

    public void fadeDelete()
    {
        animator.SetBool("deleteKeyPressed", true);
    }

}
