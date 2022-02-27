using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;

    private float offsetX = -2;
    private float offsetY = 7;
    private float offsetZ = -2;

    void LateUpdate()
    {
        transform.position = new Vector3(playerTransform.transform.position.x + offsetX, offsetY, playerTransform.transform.position.z + offsetZ);

    }
}
