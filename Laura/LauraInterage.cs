using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauraInterage : MonoBehaviour
{
    public bool EstaInteragindo{ get; set; }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("LauraInterage"))
        {
            EstaInteragindo = true;
        }
        else
        {
            EstaInteragindo = false;
        }
        
    }
}
