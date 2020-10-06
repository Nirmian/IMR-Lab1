using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour
{

    public Camera arCamera;
    private Animator animator;
    float dist;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(arCamera.GetComponent<Transform>().position, gameObject.GetComponent<Transform>().position);

        if (dist <= 200.0f)
        {
            animator.SetBool("Attacking", true);
            animator.SetBool("Skip", false);
        }
        else
        {
            animator.SetBool("Attacking", false);
            animator.SetBool("Skip", true);
        }
        Debug.Log(dist);
    }
}
