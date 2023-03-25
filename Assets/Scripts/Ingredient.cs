using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Ingredient", menuName = "Assets/Ingredients")]
public class Ingredient : MixableItems
{
    // Unique Fields
    public bool isMixed = false;
}
