using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObstacles : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hit"))
        {
            Vector3 spawnpoint = new Vector3 (0.19f, 0.71f, -4.85f);
            Instantiate(prefabToSpawn, spawnpoint, Quaternion.identity);
        }
        Destroy(collision.gameObject.transform.parent.gameObject);
        Destroy(collision.gameObject);

    }

}
