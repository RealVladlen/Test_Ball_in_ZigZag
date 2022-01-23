using System.Collections;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform forwardSpawnPoint;
    public Transform rightSpawnPoint;
    public Transform bottomBeginSpawnPoint;
    public Transform leftBeginSpawnPoint;

    private GameObject _player;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _player = other.gameObject;

            if (gameObject.tag == "Cube")
            {
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
    private void Update()
    {
        if (gameObject.transform.position.y < -7.5f)
        {
            _player.GetComponent<PathGenerator>().MovementCube();
            gameObject.GetComponentInChildren<DiamondGenerate>().GenerateDiamond();
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
