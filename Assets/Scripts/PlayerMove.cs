using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3f;
    public static float jumpForse = 2f;
    public Rigidbody2D rb;
    public Animator aim;
    public SpriteRenderer sprite;
    public GameObject win;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            aim.SetBool("isMove", true);
        }
        else
        {
            aim.SetBool("isMove", false);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            sprite.flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            sprite.flipX = false;
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * jumpForse, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            Destroy(gameObject);
            win.SetActive(true);

        }
    }
}
