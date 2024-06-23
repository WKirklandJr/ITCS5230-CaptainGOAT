using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] rockReference;

    private GameObject spawnedRock;

    [SerializeField]
    private Transform rightPos;

    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRocks());
        
    }

    IEnumerator SpawnRocks()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, rockReference.Length);

            spawnedRock = Instantiate(rockReference[randomIndex]);
        }
    }
}
