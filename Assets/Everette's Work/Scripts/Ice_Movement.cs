using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 directionToMove;

    public void FixedUpdate(){
      Move(directionToMove);
    }

    public void setMoveDirection(Vector2 _directionToMove){
      directionToMove = _directionToMove;
    }

    public void Move(Vector2 directionToMove) {
      Debug.Log("Attempting to move ICE");
      rb.AddForce(directionToMove * speed);
    }
}
