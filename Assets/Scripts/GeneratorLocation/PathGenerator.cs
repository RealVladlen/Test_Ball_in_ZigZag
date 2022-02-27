using System.Collections.Generic;
using UnityEngine;

public class PathGenerator : MonoBehaviour
{
    public Cube firstPlatform;
    public Cube cubePrefabs;

    private List<Cube> _spawnedCube = new List<Cube>();

    void Start()
    {
        SpawnedCube();
    }

    private void SpawnedCube()
    {
        firstPlatform = Instantiate(firstPlatform, new Vector3(0,0,0), Quaternion.identity);

        firstPlatform.GetComponent<MeshRenderer>().enabled = true;
        firstPlatform.GetComponent<Rigidbody>().isKinematic = true;

        _spawnedCube.Add(firstPlatform);

        while (_spawnedCube.Count <= 25)
        {
            Cube newCube = Instantiate(cubePrefabs);

            int newRandom = Random.Range(0, 2);

            if (newRandom == 0)
            {
                newCube.transform.position = _spawnedCube[_spawnedCube.Count - 1].rightSpawnPoint.position - newCube.leftBeginSpawnPoint.localPosition;
            }
            else newCube.transform.position = _spawnedCube[_spawnedCube.Count - 1].forwardSpawnPoint.position - newCube.bottomBeginSpawnPoint.localPosition;

            _spawnedCube.Add(newCube);
        }
        _spawnedCube.RemoveAt(0);
    }

    public void MovementCube()
    {
        Cube moveCube = _spawnedCube[0];

        int newRandom = Random.Range(0, 2);
        
        if (newRandom == 0)
        {
            moveCube.transform.position = _spawnedCube[_spawnedCube.Count - 1].rightSpawnPoint.position - moveCube.leftBeginSpawnPoint.localPosition;
        }
        else moveCube.transform.position = _spawnedCube[_spawnedCube.Count - 1].forwardSpawnPoint.position - moveCube.bottomBeginSpawnPoint.localPosition;

        _spawnedCube.Add(moveCube);

        _spawnedCube.RemoveAt(0);
    }



    public void RestartSpawnedCube()
    {
        Destroy(firstPlatform.gameObject);

        for (int i = 0; i < _spawnedCube.Count; i++)
        {
            Destroy(_spawnedCube[i].gameObject);
        }

        _spawnedCube.Clear();

        SpawnedCube();
    }
}

