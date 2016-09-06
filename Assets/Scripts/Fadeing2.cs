using UnityEngine;
using System.Collections;

public class Fadeing2 : MonoBehaviour
{

    public Animator animator;

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void fadeDelete()
    {
        animator.SetBool("deleteKeyPressed", true);
    }
    public void Visible()
    {
        gameObject.transform.Translate(0, 0, -2);
    }

}
