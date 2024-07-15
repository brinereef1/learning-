using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed;
    public float force;
    private int hurt;
    private Animator animator;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizon = Input.GetAxis("Horizontal");

        if (horizon > 0)
        {
            transform.localScale = new Vector3(2, 2, 1);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            animator.SetFloat("Speed", Mathf.Abs(horizon));
        }
        else if (horizon < 0)
        {
            transform.localScale = new Vector3(-2, 2, 1);
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            animator.SetFloat("Speed", Mathf.Abs(horizon));
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector2.up * force);
        } 
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("Crouching", true);
        } 
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("Striking ", true);
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            hurt++;
            Debug.Log(hurt);
            animator.SetBool("hurting", true);
            animator.SetInteger("died", hurt);
        }
        else
        {
            animator.SetFloat("Speed", -1);
            animator.SetBool("Crouching", false);
            animator.SetBool("Striking ", false);
            animator.SetBool("hurting", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        animator.SetBool("Jumping", true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Jumping", false);
    }
}
