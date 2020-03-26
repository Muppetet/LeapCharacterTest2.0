using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyCharacter : MonoBehaviour
{
    public float walkSpeed;
    public float playerJumpForce;
    public ForceMode appliedForceMode;
    public bool playerIsJumping;

    private float _xAxis;
    private float _zAxis;
    private Rigidbody _rb;
    private RaycastHit _hit;
    private Vector3 _groundLocation;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        _xAxis = Input.GetAxis("Horizontal");
        _zAxis = Input.GetAxis("Vertical");

         playerIsJumping = Input.GetButton("Jump");

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 10f, Color.blue);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out _hit, Mathf.Infinity))
        {
            if(string.Compare(_hit.collider.tag, "ground", System.StringComparison.OrdinalIgnoreCase)== 0)
            {
                _groundLocation = _hit.point;
            }
            var distanceFromPlayerToGround = Vector3.Distance(transform.position, _groundLocation);
            if(distanceFromPlayerToGround > 1f)
            {
                playerIsJumping = false;
            }
        }

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

    }

    private void FixedUpdate()
    {
        _rb.MovePosition(transform.position + Time.deltaTime * walkSpeed * 
                         transform.TransformDirection(_xAxis, 0, _zAxis));

        if (playerIsJumping)
        {
            PlayerJump(playerJumpForce, appliedForceMode);
        }
    }

    private void PlayerJump(float jumpForce, ForceMode forceMode)
    {
        _rb.AddForce(jumpForce * _rb.mass * Time.deltaTime * Vector3.up, forceMode);
    }
}
