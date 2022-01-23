using UnityEngine;

public class DiamondGenerate : MonoBehaviour
{
    [SerializeField] private GameObject _diamondPrefabs;

    void Start()
    {
        GenerateDiamond();
    }
    public void GenerateDiamond()
    {
        int random = UnityEngine.Random.Range(0, 10);

        if (random == 5)
        {
            GameObject diamond = Instantiate(_diamondPrefabs);

            diamond.transform.position = transform.position;
        }
    }
}
