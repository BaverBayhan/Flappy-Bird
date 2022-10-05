using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_checker_generator : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        int a = 49;
        float placement = 10.3f;
        for (int i = 0; i < a; i++)
        {
            Instantiate(prefab);
            prefab.transform.position = new Vector3(gameObject.transform.position.x+placement,gameObject.transform.position.y,gameObject.transform.position.z);
            placement+=9;
        }
    }

}
