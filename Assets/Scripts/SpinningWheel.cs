using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpinningWheel : MonoBehaviour
{
    [SerializeField] float spinningSpeed = 100.0f;
    public Transform rotationAxis;
    public bool IsMilaInCage = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up, Time.deltaTime * spinningSpeed);
        // Rotate around the pivot point
        if (IsMilaInCage)
        {
            transform.RotateAround(rotationAxis.position, rotationAxis.forward, spinningSpeed * Time.deltaTime);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mila")
        {
            IsMilaInCage = true;
        } else
        {
            IsMilaInCage = false;
        }
    }
}
