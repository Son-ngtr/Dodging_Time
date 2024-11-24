using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speedOfProjectile = 0.2f;
    Vector3 playerPosition;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        // playerPosition = player.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speedOfProjectile * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (gameObject.transform.position == player.position)
        {
            Destroy(gameObject);
        }
        
    }
}
