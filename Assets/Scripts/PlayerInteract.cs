using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    // Start is called before the first frame update
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
                if (collider.TryGetComponent(out DoctorNPC doctorNPC))
                {
                    doctorNPC.Interact();
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            float interactRange = 2f;
            Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliders)
            {
                if (collider.TryGetComponent(out DoctorNPC doctorNPC))
                {
                    doctorNPC.Interact2();
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            float interactRange = 2f;
            Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliders)
            {
                if (collider.TryGetComponent(out DoctorNPC doctorNPC))
                {
                    doctorNPC.Interact3();
                }
            }
        }

    }
    public DoctorNPC GetNPCUIObject()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out DoctorNPC doctorNPC))
            {
                return doctorNPC;
            }
        }
        return null;
    }
    public D1 GetNPCUIObject1()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D1 d1))
            {
                return d1;
            }
        }
        return null;
    }

    public D2 GetNPCUIObject2()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D2 d2))
            {
                return d2;
            }
        }
        return null;
    }



    public D3 GetNPCUIObject3()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D3 d3))
            {
                return d3;
            }
        }
        return null;
    }


    public D4 GetNPCUIObject4()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D4 d4))
            {
                return d4;
            }
        }
        return null;
    }

    public D5 GetNPCUIObject5()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D5 d5))
            {
                return d5;
            }
        }
        return null;
    }
    public D6 GetNPCUIObject6()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D6 d6))
            {
                return d6;
            }
        }
        return null;
    }

    public D7 GetNPCUIObject7()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D7 d7))
            {
                return d7;
            }
        }
        return null;
    }

    public D8 GetNPCUIObject8()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D8 d8))
            {
                return d8;
            }
        }
        return null;
    }

    public D9 GetNPCUIObject9()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D9 d9))
            {
                return d9;
            }
        }
        return null;
    }

    public D10 GetNPCUIObject10()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D10 d10))
            {
                return d10;
            }
        }
        return null;
    }
    public D11 GetNPCUIObject11()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D11 d11))
            {
                return d11;
            }
        }
        return null;
    }

    public D12 GetNPCUIObject12()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D12 d12))
            {
                return d12;
            }
        }
        return null;
    }

    public D13 GetNPCUIObject13()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D13 d13))
            {
                return d13;
            }
        }
        return null;
    }

    public D14 GetNPCUIObject14()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D14 d14))
            {
                return d14;
            }
        }
        return null;
    }

    public D15 GetNPCUIObject15()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D15 d15))
            {
                return d15;
            }
        }
        return null;
    }

    public D16 GetNPCUIObject16()
    {

        float interactRange = 2f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out D16 d16))
            {
                return d16;
            }
        }
        return null;
    }
}


