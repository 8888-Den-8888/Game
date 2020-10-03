using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public PlayerControls controls;
    public Rigidbody body;

    private void Awake()
    {
        controls = new PlayerControls();
        body = GetComponent<Rigidbody>();
        controls.Player.Jump.performed += _ => Jump();
    }

    private void Jump()
    {
        body.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

}
