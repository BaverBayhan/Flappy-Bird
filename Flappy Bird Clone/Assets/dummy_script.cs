using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummy_script : MonoBehaviour
{

    void FixedUpdate()
    {
        Vector2 vector2 = new Vector2(1500f, 12.86f);
        Vector2 lerp_F = Vector2.Lerp(transform.position, vector2, Time.fixedDeltaTime*0.004f);
        transform.position = lerp_F;
    }
}
