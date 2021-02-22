using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoEspecial : MonoBehaviour
{

    public GameObject alvo;
private void OnTriggerEnter2D(Collider2D other) {
   // Debug.Log(other.gameObject.name);

   if (other.CompareTag("Caixa")){
       alvo.SetActive(false);
   }

}

private void OnTriggerExit2D(Collider2D other) {
    if (other.CompareTag("Caixa")){
       alvo.SetActive(true);
   }
}

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
