using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCollectable : MonoBehaviour
{

    [SerializeField]
    private GameObject[] collectables;

    public void CheckToSpawnCollectable()
    {

        if (Random.Range(0, 2) > 0)
        {
            Instantiate(collectables[Random.Range(0, collectables.Length)]
                , transform.position, Quaternion.identity);
        }

    }

} // class
