using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleAnimation : MonoBehaviour
{
    [SerializeField] float spinningSpeed = 100.0f;
    // public Transform rotationAxis;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up, Time.deltaTime * spinningSpeed);
        // Rotate around the pivot point
        // transform.RotateAround(rotationAxis.position, rotationAxis.forward, spinningSpeed * Time.deltaTime);
    }
}
