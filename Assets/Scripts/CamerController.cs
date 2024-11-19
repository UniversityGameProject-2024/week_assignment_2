using UnityEngine;

public class CamerController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Camera speed, in meters per second")]
    public float FollowSpeed = 2f;

    [SerializeField]
    [Tooltip("Who camera will follow")]
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        //Vector3 newPos = new Vector3(target.position.x , target.position.y + 3, -10f);
        //transform.position = Vector3.Slerp(transform.position, newPos, 
        //    FollowSpeed * Time.deltaTime);
    }
}
