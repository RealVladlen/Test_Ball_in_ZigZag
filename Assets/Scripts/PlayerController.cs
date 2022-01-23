using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private int _random;

    void Start()
    {
        GlobalEventManager.SpeedUp += SpeedUp;
        GlobalEventManager.GameOver += LoadSpeed;

        _random = Random.Range(0, 2);
    }

    void Update()
    {
        if (_random == 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }

        else
            transform.Translate(Vector3.right * Time.deltaTime * _speed);

        if (Input.GetMouseButtonDown(0))
        {
            if (_random == 0)
            {
                _random = 1;
            }

            else
                _random = 0;
        }
    }
    private void SpeedUp()
    {
        _speed += 0.05f;
        Debug.Log(_speed);
    }
    private void LoadSpeed()
    {
        _speed = 3;
        Debug.Log(_speed);
    }
}
