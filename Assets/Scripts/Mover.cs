using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] Vector3 moving = new Vector3(0f, 2f, 0f); 
    [SerializeField] float moveSpeed = 5f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Implement input system 
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        Vector3 moving = new Vector3(xValue, yValue, zValue) * moveSpeed;

        transform.Translate(moving);
    }
}
