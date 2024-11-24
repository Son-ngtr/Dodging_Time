using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] Vector3 spinnerSpeed = new Vector3 (0, 2, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinnerSpeed);
    }
}
