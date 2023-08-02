using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanPrefabGrid : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    public int gridZSpawn = 125;
    public float gridSpaceingOffset = 40f;
    public Vector3 gridOrigin = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        SpawnGrid();
    }

    void SpawnGrid()
    {
            for (int z = 1; z < gridZSpawn; z++)
            {
                Vector3 spawnPosition = new Vector3(0, 0, z * gridSpaceingOffset) + gridOrigin;
                PickAndSpawn(spawnPosition, Quaternion.identity);
            }
    }

    void PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn);
    }
}
