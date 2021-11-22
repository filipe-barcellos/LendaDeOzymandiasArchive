using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAberta : MonoBehaviour
{   
    private AudioSource sound;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }
    public void Abre()
    {
        sound.Play();
        _animator.SetBool("AbrePorta",true);
    }
}
