using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_BreakableWall : MonoBehaviour
{
    [SerializeField] private string tagToLookFor;
    [SerializeField] private float impactTreshHold = 1.0f;
    [SerializeField] private GameObject breakingParticles;

    public void OnCollisionEnter2D(Collision2D col){
      Vector2 impactVelocity = col.relativeVelocity;
      //Debug.Log("Impact Velocity = " + impactVelocity.x);

      if(col.gameObject.tag == tagToLookFor && impactVelocity.x > impactTreshHold) WallBreak();
      //else Debug.Log("Wall is good");
    }

    private void WallBreak(){
      Instantiate(breakingParticles, gameObject.transform.position, Quaternion.identity);
      Destroy(gameObject, 0.1f);
    }
}
