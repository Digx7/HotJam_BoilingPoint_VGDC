using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float timeDelay;

    public void Start(){
      Destroy(gameObject, timeDelay);
    }
}
