using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFXLifeTimer : MonoBehaviour
{

    [SerializeField]
    private float timer = 3f;

    private void Start()
    {
        Destroy(gameObject, timer);
    }

}
