using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public Vector2 direction = Vector2.down;
    public float timer = 0;
    public float moveDuration = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        timer = Time.deltaTime + timer;
        if (timer >= moveDuration)
        {
            direction = direction * -1;
            timer = 0;
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
           
        }
    }
}
