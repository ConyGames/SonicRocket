using UnityEngine;
/*
 * Script to make the camera follow the given object
 */

public class ObjectFollow2D : MonoBehaviour
{
    [SerializeField] private Transform ObjectToFollow;
    [SerializeField] private Vector3 Offset = new Vector3();
    public float FollowSPeed;
    private Vector3 FollowPositon;

    void Start(){
        FollowPositon = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        GetCameraPosition();
        transform.position = Vector3.Lerp(transform.position, 
                                            FollowPositon, 
                                            FollowSPeed * Time.deltaTime
                                        );
    }

    void GetCameraPosition(){
        FollowPositon = Vector3.right * ObjectToFollow.position.x+
                        Vector3.up * ObjectToFollow.position.y+
                        Vector3.forward * transform.position.z;
        FollowPositon += Offset;
    }
}
