using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 _velocity;
    private bool grounded = true;
    [SerializeField] private LayerMask whatIsGround;

    public bool Grounded 
    {
        get { return grounded; }
        set { grounded = value; }
    }

    public Vector3 Velocity
    {
        get { return _velocity; }
        set { _velocity = value; }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += _velocity * Time.deltaTime;
        RaycastHit hit;
        //Send a raycast to detect if player is grounded
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1, whatIsGround))
        {
            grounded = true;
        }
    }

}
