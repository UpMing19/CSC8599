using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class P12 : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliders)
            {
                if (collider.TryGetComponent(out D12 d12))
                {
                    d12.Interact();
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            float interactRange = 2f;
            Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliders)
            {
                if (collider.TryGetComponent(out D12 d12))
                {
                    d12.Interact2();
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            float interactRange = 2f;
            Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliders)
            {
                if (collider.TryGetComponent(out D12 d12))
                {
                    d12.Interact3();
                }
            }
        }


    }
}