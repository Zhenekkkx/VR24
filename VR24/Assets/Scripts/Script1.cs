using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Script1 : MonoBehaviour
{
    public GameObject item;
    public void UseButton()
    {
        item.SetActive(!(item.activeSelf));
    }
}