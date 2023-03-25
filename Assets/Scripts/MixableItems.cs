using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MixableItems : ScriptableObject
{
    // Generic Fields
    public string itemName;
    public string nameOverride = null;
    public string description;
    public float weight = 1f;
    public float toxicity;
    public float strength;
    public float mixStrengthening;
    public float addictiveness;
}

