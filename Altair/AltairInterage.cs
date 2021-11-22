using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltairInterage : MonoBehaviour
{
    public bool EstaInteragindo{ get; set; }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("AltairInterage"))
        {
            EstaInteragindo = true;
        }
        else
        {
            EstaInteragindo = false;
        }
        
    }
}
