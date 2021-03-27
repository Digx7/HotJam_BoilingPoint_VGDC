using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Movement : MonoBehaviour
{
  [SerializeField] private Rigidbody2D rb;
  [SerializeField] private float speed, jumpSpeed, jumpTime, gravity;
  [SerializeField] private bool isJumping, isTouchingGround;
  [SerializeField] private Vector2 directionToMove;

  public void FixedUpdate(){
    if(!isJumping)directionToMove.y = -gravity;
    else directionToMove.y = jumpSpeed;
    Move(directionToMove);
  }

  public void setMoveDirection(Vector2 _directionToMove){
    directionToMove.x = _directionToMove.x;
  }

  public void setIsJumping(){
    if(!isJumping && isTouchingGround) StartCoroutine(jumping());
  }

  public void Move(Vector2 directionToMove) {
    Debug.Log("Attempting to move WATER");
    rb.velocity = directionToMove * speed;
  }

  public void OnCollisionEnter2D(Collision2D col){
    if(col.gameObject.tag == "Ground") isTouchingGround = true;
  }

  IEnumerator jumping(){
    isJumping = true;
    isTouchingGround = false;
    yield return new WaitForSeconds(jumpTime);
    isJumping = false;
  }
}
