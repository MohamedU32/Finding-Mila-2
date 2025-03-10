using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenBox : MonoBehaviour
{
    [SerializeField] private GameObject _replacement;
    [SerializeField] private bool _open = false;
    private XRGrabInteractable _interactable;

    // Start is called before the first frame update
    void Start()
    {
        _interactable = GetComponent<XRGrabInteractable>();
        _interactable.selectEntered.AddListener(OnGrab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGrab (SelectEnterEventArgs args)
    {
        if (_open) return;
        else
        {
            var replacement = Instantiate(_replacement, transform.position, transform.rotation);
            var rbs = replacement.GetComponentsInChildren<Rigidbody>();
            Destroy(gameObject);
        }


        

    }   
}
