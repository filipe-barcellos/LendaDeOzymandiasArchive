using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacaPressao : MonoBehaviour
{
    private Animator _animator;
    public static bool pisou;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        _animator.SetBool("Pressionou",true);
        pisou = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        _animator.SetBool("Pressionou",false);
        pisou = false;
    }
}
