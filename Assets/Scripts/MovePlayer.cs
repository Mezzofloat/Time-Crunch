using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float speed = 7f;

    Vector3 input;
    Vector3 prevPosition;

    float xInput, yInput;
    float x, y;

    bool shouldMove = true;

    Animator animator;
    Rigidbody2D rb;

    RaycastHit2D hit;

    void Awake() {
        animator = GetComponent<Animator>();
        animator.speed = 0.5f;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        if (!shouldMove) {
            input = Vector3.zero;
            animator.SetBool("IsWalking", false);
            return;
        }

        input = value.Get<Vector2>();
        
        animator.SetFloat("X", input.x);
        animator.SetFloat("Y", input.y);
        animator.SetBool("IsWalking", input.x != 0 || input.y != 0);
    }

    void FixedUpdate()
    {
        xInput = input.x;
        yInput = input.y;

        x = xInput + transform.position.x;
        y = yInput + transform.position.y;

        if (x*x + y*y <= 4.6f * 4.6f && !Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), input, 1/5f)) {
            transform.Translate(input * speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag.Equals("Box")) {
            animator.SetBool("IsPushing", true);
        }
    }
    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag.Equals("Box")) {
            animator.SetBool("IsPushing", false);
        }
    }

    public void SetFalse() => shouldMove = false;
}
