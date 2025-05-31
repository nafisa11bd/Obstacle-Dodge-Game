using UnityEngine;
using System.Collections;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    [SerializeField] float timeToDrop;// Time in seconds before the object drops
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;

    
          
    }

    void Update()
    {
        
        if (Time.time > timeToDrop)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity  = true;
        }
    
        
    }
}