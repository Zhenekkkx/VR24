using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Animator animator;
    void OnMouseDown()
    {
        animator.SetTrigger("Go");
    }
}
