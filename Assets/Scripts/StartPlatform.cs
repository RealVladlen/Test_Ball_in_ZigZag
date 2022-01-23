using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y < -7.5f)
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
