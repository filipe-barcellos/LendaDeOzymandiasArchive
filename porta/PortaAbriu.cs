using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAbriu : MonoBehaviour
{
    private AudioSource sound;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlacaPressao.pisou == true)
        {
            sound.Play();
            _animator.SetBool("AbrePorta",true);
        }
    }
}
