using UnityEngine;

public class CamerController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Camera speed, in meters per second")]
    public float FollowSpeed = 2f;

    [SerializeField]
    [Tooltip("Who camera will follow")]
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newPos = new Vector3(target.position.x , target.position.y + 3, -10f);
        //transform.position = Vector3.Slerp(transform.position, newPos, 
        //    FollowSpeed * Time.deltaTime);
    }
}
