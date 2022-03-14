using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLifeTimer : MonoBehaviour
{

    [SerializeField]
    private float timer = 3f;

    private void OnEnable()
    {
        Invoke("DeactivateProjectile", timer);
    }

    private void OnDisable()
    {
        CancelInvoke("DeactivateProjectile");
    }

    void DeactivateProjectile()
    {
        if (gameObject.activeInHierarchy)
            gameObject.SetActive(false);
    }

}
