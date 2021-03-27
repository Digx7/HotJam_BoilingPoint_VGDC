using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_ControlsHandler : MonoBehaviour
{
    [SerializeField] private Ice_Controls Ice_Controls;
    [SerializeField] private Ice_Movement Ice_Movement;

    public void Awake() {
        Ice_Controls = new Ice_Controls();
        BindInputs();
    }

    public void BindInputs() {
        Ice_Controls.Movement.Move.performed += ctx => Ice_Movement.setMoveDirection(ctx.ReadValue<Vector2>());

    }

    // --- Enable/Disable --------------------------------

    // This will enable the Input Action Map
    private void OnEnable() {
        Ice_Controls.Enable();
    }

    // This will enable the Input Action Map
    private void OnDisable() {
        Ice_Controls.Disable();
    }
}
