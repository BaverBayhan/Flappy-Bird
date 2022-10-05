using UnityEngine;


public class platform_script : MonoBehaviour
{
    private float time1;
    private void Start()
    {
        time1=0;
    }
    private void FixedUpdate()
    {
        if (time1>7)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x+8,gameObject.transform.position.y,gameObject.transform.position.z);
            time1=0;
        }
        else
        {
            time1+=Time.fixedDeltaTime;
        }
    }
}
