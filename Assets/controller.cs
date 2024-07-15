using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float speed;
    private float horizon;
    private int healthbar = 10;
    public string walk;
    public string attack;
    private Animator animator;
    public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizon = Input.GetAxis("Horizontal");
        if (horizon > 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool(walk, true);
        } 
        else if (horizon < 0)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool(walk, true);
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetBool(attack, true);
        }
        else
        {
            animator.SetBool(walk, false);
            animator.SetBool(attack, false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fire")
        {
            animator.SetBool("hurting", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("hurting", false);
    }

}