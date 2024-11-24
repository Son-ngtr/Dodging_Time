using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 2.0f;

    MeshRenderer myMeshRender;
    Rigidbody myRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRender = GetComponent<MeshRenderer>();
        myMeshRender.enabled = false;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        // Debug.Log("Time elapsed: " + elapsedTime + " seconds");

        if(elapsedTime > timeToDrop)
        {
            dropObject();
        }
    }

    private void dropObject()
    {
        myMeshRender.enabled = true;
        myRigidbody.useGravity = true;
    }
}
