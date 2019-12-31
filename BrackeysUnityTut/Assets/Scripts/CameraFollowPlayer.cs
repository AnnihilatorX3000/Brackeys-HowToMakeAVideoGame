using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;      // playerPos -> cameraPos

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
