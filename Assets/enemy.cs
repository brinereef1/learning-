using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private int health = 10;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        animator.SetInteger("died", health);
        if (health < 1)
        {
            Destroy(this.gameObject, 1f);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            animator.SetBool("attacking", true);
        }
        else
        {
            animator.SetBool("attacking", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            health--;
            Debug.Log(health);
            animator.SetBool("hurting", true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy") 
            animator.SetBool("hurting", false);
    }
}
