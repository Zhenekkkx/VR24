using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Script2 : MonoBehaviour
{
    public int y = 7;
    public Text Mytxt;
    public void OnCollisionEnter(Collision collision)
    {
        y--;
        Mytxt.text = y.ToString();
    }
}
