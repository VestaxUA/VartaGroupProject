using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator animator;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;
    [HideInInspector]
    public Vector2 moveDir;
    [HideInInspector]
    public Vector2 lastMovedVector;

    Rigidbody2D rb;
    public CharacterScriptableObject characterData;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastMovedVector = new Vector2(1, 0f);
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        InputManagement();
        UpdateAnimator();
    }

    void FixedUpdate()
    {
        Move();
    }

    void InputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;

        if (moveDir.x != 0)
        {
            lastHorizontalVector = moveDir.x;
            lastMovedVector = new Vector2(lastHorizontalVector, 0f);
        }

        if (moveDir.y != 0)
        {
            lastVerticalVector = moveDir.y;
            lastMovedVector = new Vector2(0f, lastVerticalVector);
        }

        if (moveDir.x != 0 && moveDir.y != 0)
        {
            lastMovedVector = new Vector2(lastHorizontalVector, lastVerticalVector);
        }
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * characterData.MoveSpeed, moveDir.y * characterData.MoveSpeed);
    }

    void UpdateAnimator()
    {
        animator.SetFloat("Horizontal", moveDir.x);
        animator.SetFloat("Vertical", moveDir.y);
        animator.SetFloat("Speed", moveDir.sqrMagnitude);

        // Додайте обертання персонажа по осі X
        if (moveDir.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (moveDir.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
