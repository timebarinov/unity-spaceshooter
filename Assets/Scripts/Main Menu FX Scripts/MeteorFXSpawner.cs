using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorFXSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] meteors;

    private List<GameObject> spawnedMeteors = new List<GameObject>();

    [SerializeField]
    private float minSpawnTime = 3f, maxSpawnTime = 7f;

    private float spawnTimer;

    [SerializeField]
    private float minX, maxX;

    private Vector3 spawnPos;

    private int spawnNum;
    private int activatedMeteors;

    [SerializeField]
    private bool moveDown;

    private void Start()
    {
        spawnTimer = Time.time + Random.Range(1f, 2f);
        SpawnInitialNumberOfMeteors(40);
    }

    private void Update()
    {
        if (Time.time > spawnTimer)
            SpawnMeteorsFromPool();
    }

    void SpawnInitialNumberOfMeteors(int spawnNum)
    {
        for (int i = 0; i < spawnNum; i++)
        {
            GameObject newMeteor = Instantiate(meteors[Random.Range(0, meteors.Length)]);
            newMeteor.transform.SetParent(transform);
            newMeteor.SetActive(false);
            spawnedMeteors.Add(newMeteor);
        }
    }

    void SpawnMeteorsFromPool()
    {
        spawnNum = Random.Range(1, 6);
        activatedMeteors = 0;

        for (int i = 0; i < spawnedMeteors.Count; i++)
        {

            if (!spawnedMeteors[i].activeInHierarchy)
            {
                spawnPos = new Vector3(Random.Range(minX, maxX), transform.position.y, 0f);

                spawnedMeteors[i].SetActive(true);

                spawnedMeteors[i].transform.position = spawnPos;

                if (moveDown)
                    spawnedMeteors[i].GetComponent<MeteorFXMovement>().moveDown = true;

                activatedMeteors++;

                if (activatedMeteors == spawnNum)
                    break;

            }

        }

        spawnTimer = Time.time + Random.Range(minSpawnTime, maxSpawnTime);

    }

} // class
