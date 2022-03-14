using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField]
    private float speed = 3f;

    public float minDamage = 10f;
    public float maxDamage = 30f;

    private float projectileDamage;

    [SerializeField]
    private AudioClip spawnSound;

    [SerializeField]
    private float soundVolume = 0.2f;

    [SerializeField]
    private GameObject boomEffect;

    [SerializeField]
    private AudioClip destroySound;

    private void Start()
    {
        projectileDamage = (int)Random.Range(minDamage, maxDamage);
    }

    private void OnEnable()
    {
        if (spawnSound)
            AudioSource.PlayClipAtPoint(spawnSound, new Vector3(0f, 6f, 0f), soundVolume);
    }

    private void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag(TagManager.PLAYER_TAG))
        {
            collision.GetComponent<PlayerHealth>().TakeDamage(projectileDamage);
        }

        if (collision.CompareTag(TagManager.ENEMY_TAG) || collision.CompareTag(TagManager.METEOR_TAG))
        {
            collision.GetComponent<EnemyHealth>().TakeDamage(projectileDamage, 0f);
        }

        if (!collision.CompareTag(TagManager.UNTAGGED_TAG) &&
            !collision.CompareTag(TagManager.COLLECTABLE_TAG))
        {
            gameObject.SetActive(false);
        }

    }

} // class
