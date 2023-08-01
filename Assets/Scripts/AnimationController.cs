using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    public bool isMovingRight = false;
    public bool isMovingLeft = false;

    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        isMovingRight = Input.GetKey(rightKey);
        isMovingLeft = Input.GetKey(leftKey);

        animator.SetBool("isMovingRight", isMovingRight);
        animator.SetBool("isMovingLeft", isMovingLeft);
    }
}
