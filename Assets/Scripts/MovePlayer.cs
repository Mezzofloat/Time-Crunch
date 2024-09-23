using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float speed = 7f;

    Vector3 input;

    Vector3 xInput, yInput;

    bool shouldMove = true;

    Animator animator;

    void Awake() {
        animator = GetComponent<Animator>();
        animator.speed = 0.5f;
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
        xInput = new Vector3(input.x, 0);
        yInput = new Vector3(0, input.y);

        transform.Translate(xInput * speed * Time.deltaTime);
        transform.Translate(yInput * speed * Time.deltaTime);
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
