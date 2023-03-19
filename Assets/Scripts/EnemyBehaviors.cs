using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviors : MonoBehaviour
{
    public float walkSpeed;

    Rigidbody2D rigidBody2D;

    public Animator anim;
    public enum MovementState { walking, charging }
    public MovementState state = MovementState.walking;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        rigidBody2D.velocity = new Vector2(walkSpeed, 0f);
        
        UpdateAnimationState();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "TurnBox")
        {
            walkSpeed = -walkSpeed;
            transform.Rotate(0f, 180f, 0f);
        }
    }

    void UpdateAnimationState()
    {
        MovementState state;
        if (walkSpeed != 0f)
        {
            state = MovementState.walking;
        }
        else
        {
            state = MovementState.charging;
        }

        anim.SetInteger("state", (int)state);
    }
}
