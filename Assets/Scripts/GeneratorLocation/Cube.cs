using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform forwardSpawnPoint;
    public Transform rightSpawnPoint;
    public Transform bottomBeginSpawnPoint;
    public Transform leftBeginSpawnPoint;

    private GameObject _player;

    [SerializeField] private float _lowPoint = -7.5f;


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _player = other.gameObject;

            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    private void Update()
    {
        if (gameObject.transform.position.y < _lowPoint)
        {
            _player.GetComponent<PathGenerator>().MovementCube();
            gameObject.GetComponentInChildren<DiamondGenerate>().GenerateDiamond();
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
