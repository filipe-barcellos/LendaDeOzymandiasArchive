using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreiaBoa : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void Quebrar()
    {
        _animator.SetBool("Quebrar",true);
        Destroy(gameObject,1f);
    }
}
