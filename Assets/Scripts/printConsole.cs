using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class printConsole : MonoBehaviour
{

    public Drug drug;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name: " + drug.name);
        Debug.Log("Desc: " + drug.description);
        Debug.Log("Toxicity: " + drug.toxicity);
        Debug.Log("Stenght: " + drug.strength);
        Debug.Log("Mix Stenghtening : " + drug.mixStrengthening);
        Debug.Log("Addictiveness: " + drug.addictiveness);
        Debug.Log("Is Pure: " + drug.isPure);
    }
}
