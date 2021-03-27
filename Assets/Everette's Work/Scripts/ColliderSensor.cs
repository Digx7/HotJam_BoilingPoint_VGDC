using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderSensor : MonoBehaviour
{
    public UnityEvent ouch;

    public void OnCollisionEnter2d(Collider2D col){
      ouch.Invoke();
    }
}
