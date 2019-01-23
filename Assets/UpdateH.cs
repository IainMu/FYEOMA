using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateH : MonoBehaviour
{
    static Text value;
    // Use this for initialization
    void Start()
    {
        value = gameObject.GetComponent<Text>();
    }

    public static void setText(string val)
    {
        value.text = val;
    }
}
