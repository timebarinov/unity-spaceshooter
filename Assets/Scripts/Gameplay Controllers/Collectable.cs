using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CollectableType
{
    Health,
    Laser,
    Rocket,
}

public class Collectable : MonoBehaviour
{

    public CollectableType type;

    [SerializeField]
    private float moveSpeed = 5f;

    private Vector3 tempPos;

    [HideInInspector]
    public float healthValue;

    private float minHealth = 10f, maxHealth = 30f;

    private void Start()
    {
        healthValue = Random.Range(minHealth, maxHealth);
    }

    private void Update()
    {
        tempPos = transform.position;
        tempPos.y -= moveSpeed * Time.deltaTime;
        transform.position = tempPos;
    }

    private void OnDisable()
    {
        SoundManager.instance.PlayPickUpSound();
    }

} // class
