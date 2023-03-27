using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Drug", menuName = "Assets/Drug")]
public class Drug : MixableItems
{

    // Unique Fields
    public bool isPure = true;
    public string nsfwTrueName = null;
    public List<string> nickNames = null;
}
