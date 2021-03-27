using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormChanger : MonoBehaviour
{
    [SerializeField] GameObject[] playerForms;
    [SerializeField] GameObject newFormSpawnPoint;

    public enum Forms
    {
      solid, liquid, gas
    }
    public Forms currentForm;

    public void OnCollisionEnter2D (Collision2D col){
      if(col.gameObject.GetComponent<Burner>() != null){
          Burner burnerYouTouched = col.gameObject.GetComponent<Burner>();
          if(canYouChangeForms(_Burner : burnerYouTouched)){
            burnerYouTouched.useItem();
            swapForms(_Burner : burnerYouTouched);
            Destroy(gameObject, 0.1f);
          }
        }
      if(col.gameObject.GetComponent<Freezer>() != null){
          Freezer freezerYouTouched = col.gameObject.GetComponent<Freezer>();
          if(canYouChangeForms(_Freezer : freezerYouTouched)){
            freezerYouTouched.useItem();
            swapForms(_Freezer : freezerYouTouched);
            Destroy(gameObject, 0.1f);
          }
        }
    }

    private bool canYouChangeForms(Burner _Burner = null, Freezer _Freezer = null){
      if(currentForm == Forms.solid && _Freezer != null) return false;
      else if(currentForm == Forms.gas && _Burner != null) return false;
      else return true;
    }

    private void swapForms(Burner _Burner = null, Freezer _Freezer = null){
      if(currentForm == Forms.liquid && _Freezer != null) spawnNewForm(playerForms[0]);
      if(currentForm == Forms.gas && _Freezer != null) spawnNewForm(playerForms[1]);
      if(currentForm == Forms.solid && _Burner != null) spawnNewForm(playerForms[1]);
      if(currentForm == Forms.liquid && _Burner != null) spawnNewForm(playerForms[2]);
    }

    private void spawnNewForm(GameObject formToSpawn){
      Instantiate(formToSpawn, newFormSpawnPoint.transform.position, Quaternion.identity);
    }
}
