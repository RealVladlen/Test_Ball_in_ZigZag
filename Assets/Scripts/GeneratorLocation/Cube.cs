using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform forwardSpawnPoint;
    public Transform rightSpawnPoint;
    public Transform bottomBeginSpawnPoint;
    public Transform leftBeginSpawnPoint;

    private PathGenerator _player;
    private DiamondGenerate _diamondGenerate;

    private Rigidbody _rigidbody;

    [SerializeField] private float _lowPoint = -7.5f;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _diamondGenerate = gameObject.GetComponentInChildren<DiamondGenerate>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (TryGetComponent(out PathGenerator player))
        {
            _player = player;

            _rigidbody.isKinematic = false;
        }
    }
    private void Update()
    {
        if (gameObject.transform.position.y < _lowPoint)
        {
            _player?.MovementCube();
            _diamondGenerate.GenerateDiamond();
            _rigidbody.isKinematic = true;
        }
    }
}
