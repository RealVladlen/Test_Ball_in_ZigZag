using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    private Transform _transform;

    [SerializeField] private float _lowPoint = -7.5f;

    private void Start()
    {
        _transform = gameObject.transform;
    }
    void Update()
    {
        if (_transform.position.y < _lowPoint)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}