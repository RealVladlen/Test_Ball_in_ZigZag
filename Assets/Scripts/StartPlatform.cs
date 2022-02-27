using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    
    private Rigidbody _rigidbody;

    private Transform _transform;

    [SerializeField] private float _lowPoint = -7.5f;

    private void Start()
    {
        _meshRenderer = gameObject.GetComponent<MeshRenderer>();
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _transform = gameObject.transform;
    }
    void Update()
    {
        if (_transform.position.y < _lowPoint)
        {
            _meshRenderer.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (TryGetComponent(out PlayerMove player))
        {
            _rigidbody.isKinematic = false;
        }
    }
}