using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_pipe_generator : MonoBehaviour
{
    public GameObject prefab_level1_type1;
    public GameObject prefab_level1_type2;
    public GameObject prefab_level1_type3;
    public GameObject prefab_level1_type4;
    public GameObject prefab_level1_type5;
    public GameObject prefab_level1_type6;
    public GameObject prefab_level1_type7;
    private List<GameObject> prefabs;
    private void Start()
    {
        GameObject[] GO_array = { prefab_level1_type1, prefab_level1_type2, prefab_level1_type3,prefab_level1_type4, prefab_level1_type5, prefab_level1_type6, prefab_level1_type7 };
        int i = 0;
        prefabs = new List<GameObject>();
        while (i<50)
        {
            int random_num=Random.Range(0,7);
            GameObject random_pipe=Instantiate(GO_array[random_num]);
            random_pipe.transform.position=new Vector3(86.49f,gameObject.transform.position.y,gameObject.transform.position.z);
            i++;
            prefabs.Add(random_pipe);
        }
        float k = 86.5f;
        for (i=0; i<50; i++)
        {
            prefabs[i].transform.position=new Vector3(k, gameObject.transform.position.y, gameObject.transform.position.z);
            k+=9;
        }

    }
}
