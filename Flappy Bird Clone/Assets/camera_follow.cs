using UnityEngine;
public class camera_follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothfactor;
    private void FixedUpdate()
    {
        Follow();
    }
    void Follow()
    {
        Vector3 target_pos=target.position+offset;
        Vector3 smoothed_pos = Vector3.Lerp(transform.position, target_pos, smoothfactor*Time.deltaTime);
        transform.position=smoothed_pos;
    }
}
