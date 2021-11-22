using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LauraInteragirComBotao : MonoBehaviour
{
    [SerializeField]
    private LauraInterage _lauraInterage;
    [SerializeField]
    private UnityEvent _botaoApertado;
    private bool _podeExecutar;

    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_podeExecutar)
        {
            if(_lauraInterage.EstaInteragindo==true)
            {
                _animator.SetBool("Apertou",true);
                _botaoApertado.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        _podeExecutar = true;
    }
    private void OnTriggerExit2D(Collider2D Collision)
    {
        _podeExecutar = false;
    }
}
