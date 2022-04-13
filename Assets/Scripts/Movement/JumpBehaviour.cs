using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false;
    public GameObject Player;
    public float Force;

    // Update is called once per frame
    void Update()
    {
        //If button is pressed and getcomponent and player is on ground
        if (isPressed && Player.GetComponent<MovementBehaviour>().Grounded)
        {
            Player.GetComponent<Rigidbody>().AddForce(Vector3.up * Force);
            Player.GetComponent<MovementBehaviour>().Grounded = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    
}
