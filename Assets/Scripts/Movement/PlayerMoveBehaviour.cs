using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Camera _camera;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    private Vector3 _moveLeft;

    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }

    public Vector3 MoveLeft
    {
        get { return _moveLeft; }
        set { _moveLeft = value; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void MoveLeftButton()
    {
        MoveLeft = new Vector3(0, 0, -1);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = MoveDirection * _speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(transform.position + velocity);
    }
}
