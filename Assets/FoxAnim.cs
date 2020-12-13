using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnim : MonoBehaviour
{
    public Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimLook()
    {
        Anim.Play("LookAround", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimWalk()
    {
        Anim.Play("Change1", -1, 0f);
        Anim.speed = 1f;
    }

    public void AnimRun()
    {
        Anim.Play("Change2",-1, 0f);
        Anim.speed = 1f;
    }
    
}
