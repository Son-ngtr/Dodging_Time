using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] List<GameObject> projectiles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach(var projectile in projectiles)
            {
                projectile.SetActive(true);
               
            }
            Destroy(gameObject);
        }
    }
}
