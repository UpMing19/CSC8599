using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerInteract playerInteract;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("GetNPCUIObject()结果 = " + playerInteract.GetNPCUIObject());
        if (playerInteract.GetNPCUIObject())
        {
            Show();
        }
        else if (playerInteract.GetNPCUIObject1())
        {
            Show();
        }
        else if (playerInteract.GetNPCUIObject2())
        {
            Show();
        }
        else if (playerInteract.GetNPCUIObject3())
        {
            Show();
        }
        else if (playerInteract.GetNPCUIObject4())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject5())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject6())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject7())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject8())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject9())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject10())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject11())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject12())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject13())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject14())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject15())
        {
            Show();
        }
           else if (playerInteract.GetNPCUIObject16())
        {
            Show();
        }

        else
        {
            Hide();
        }



        // if (playerInteract.GetNPCUIObject2())
        // {
        //     Show();
        // }
        // else
        // {
        //     Hide();
        // }
        // if (playerInteract.GetNPCUIObject3())
        // {
        //     Show();
        // }
        // else
        // {
        //     Hide();
        // }
    }

    private void Show()
    {
        containerGameObject.SetActive(true);
    }

    // Update is called once per frame
    private void Hide()
    {
        containerGameObject.SetActive(false);
    }
}
