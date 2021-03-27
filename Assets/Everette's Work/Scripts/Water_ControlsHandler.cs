using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_ControlsHandler : MonoBehaviour
{
  [SerializeField] private Water_Controls Water_Controls;
  [SerializeField] private Water_Movement Water_Movement;

  public void Awake() {
      Water_Controls = new Water_Controls();
      BindInputs();
  }

  public void BindInputs() {
      Water_Controls.Main.Move.performed += ctx => Water_Movement.setMoveDirection(ctx.ReadValue<Vector2>());
      Water_Controls.Main.Jump.performed += ctx => Water_Movement.setIsJumping();
  }

  // --- Enable/Disable --------------------------------

  // This will enable the Input Action Map
  private void OnEnable() {
      Water_Controls.Enable();
  }

  // This will enable the Input Action Map
  private void OnDisable() {
      Water_Controls.Disable();
  }
}
