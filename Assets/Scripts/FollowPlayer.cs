using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private float offsetX = -2;
    private float offsetY = 7;
    private float offsetZ = -2;

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x + offsetX, offsetY, player.transform.position.z + offsetZ);

    }
}
