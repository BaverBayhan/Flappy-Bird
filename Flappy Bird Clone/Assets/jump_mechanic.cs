using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_mechanic : MonoBehaviour
{
    private float jump_speed = 100f;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.transform.position=new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -5);

    }
    private void FixedUpdate()
    {
        float jump = Input.GetAxis("Jump");
        Vector2 move_vector=new Vector2(0, jump*2.3f);
        rb.AddForce(move_vector*jump_speed);

        Vector3 vector3 = new Vector3(1500f, 12f,-5);
        Vector3 lerp_F = Vector3.Lerp(transform.position, vector3, Time.fixedDeltaTime*0.00398f);
        transform.position = lerp_F;

    }


}
