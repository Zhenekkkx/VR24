using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator anim_;
    void OnMouseDown()
    {
        anim_.SetTrigger("Start");
    }
}
