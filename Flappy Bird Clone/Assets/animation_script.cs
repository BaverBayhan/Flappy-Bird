using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_script : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
      animator=gameObject.GetComponent<Animator>();  
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            animator.Play("New State 0");
        }
    }
}
