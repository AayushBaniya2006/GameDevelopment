using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainCharacter : MonoBehaviour
{
    public InputMaster controls;

    void Awake()
    {
        controls = new InputMaster();
        controls.Player.Move.performed += ctx => Move();
    }

    void Move()
    {
        Debug.Log("Move");
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
