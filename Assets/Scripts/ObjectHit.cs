using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private int collisionCount = 0;
    private const int maxCollisions = 3;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            collisionCount++;

            if (collisionCount > maxCollisions)
            {
                Destroy(gameObject);
            }
        }
    }

}
