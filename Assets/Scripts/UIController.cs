using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _startPannel;
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject _generator;

    [SerializeField] private float _lowPoind = -10f;

    private void Start()
    {
        StartPosition();

        _startPannel.SetActive(true);
    }
    void Update()
    {
        if (transform.position.y <= _lowPoind)
        {
            _generator.GetComponent<PathGenerator>().RestartSpawnedCube();

            GlobalEventManager.GameOver();

            GameOver();
        }
    }

    private void StartPosition()
    {
        _player.position = new Vector3(0, 1f, 0);

        Time.timeScale = 0;

        _startPannel.SetActive(true);
    }
    public void GameOver()
    {
        _player.position = new Vector3(0, 1f, 0);

        Time.timeScale = 0;

        _startPannel.SetActive(true);
    }

    public void StartGame()
    {
        Time.timeScale = 1;

        _startPannel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Diamond")
        {
            GlobalEventManager.DiamondPickUp();
            other.GetComponent<Diamond>().Unsubscribe();
            Destroy(other.gameObject);
        }
    }
}
