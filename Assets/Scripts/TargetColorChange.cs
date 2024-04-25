using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColorChange : MonoBehaviour
{

    public void ChangeColor(Color newColor)
    {
        GetComponent<Renderer>().material.color = newColor;
    }


}
