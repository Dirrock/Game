using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public int velocidad;
    public int fuerzaSalto;

    Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-velocidad, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(velocidad, rb.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Suelo")
        {
            rb.AddForce(new Vector2(0, fuerzaSalto));
        }
        
        if (collision.collider.tag == "Traps")
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
