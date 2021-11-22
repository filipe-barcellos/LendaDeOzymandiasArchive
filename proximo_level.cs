using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class proximo_level : MonoBehaviour
{
    public string lvlname;
    private Animator _animator;
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            if(lvlname == "ldo_3")
            {
                if(GameController.instance.totalScore == 1)
                {
                    SceneManager.LoadScene(lvlname);
                }
            }
            else
            {
                SceneManager.LoadScene(lvlname);
            }
            
        }
    }
}
