using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezer : MonoBehaviour
{
    public void useItem(){
      Destroy(gameObject);
    }
}
