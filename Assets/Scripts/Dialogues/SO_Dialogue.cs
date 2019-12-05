using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SO_Dialogue
{
    [TextArea(3, 10)]
    [SerializeField] private string[] sentences;

    public string[] Sentences => sentences;
}
