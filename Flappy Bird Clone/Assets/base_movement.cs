using System.Collections.Generic;
using UnityEngine;

public class base_movement : MonoBehaviour
{
    public Transform alter1;
    public Transform alter2;
    public Transform alter3;
    private List<Transform> list1;
    float groundTime;
    private void Start()
    {
        list1=new List<Transform>() { gameObject.transform, alter1,alter2, alter3 };
        groundTime=0;
    }
    private void FixedUpdate()
    {
        if (groundTime>6.4f)
        {
            Arrange_base_position();
            list1.Add(list1[0]);
            list1.RemoveAt(0);
            groundTime=0;
        }
        else
        {
            groundTime+=Time.fixedDeltaTime;
        }
    }
    void Arrange_base_position()
    {
        list1[0].position=new Vector3(list1[0].position.x+30f*4, list1[0].position.y, list1[0].position.z);
    }
}
