using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmadilhaFogo : MonoBehaviour
{

    public GameObject armadilhaDesligada;
    public GameObject armadilhaLigada;

    public bool ligado;

    public float delayInicial;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        AtualizarEstadoArmadilha();
        InvokeRepeating("AlternarEstadoArmadilha", delayInicial, delay);
    }

    // Update is called once per frame
    void AlternarEstadoArmadilha()
    {
        ligado = !ligado;
         AtualizarEstadoArmadilha();
       
    }

    void AtualizarEstadoArmadilha() {
         armadilhaDesligada.SetActive(!ligado);
        armadilhaLigada.SetActive(ligado);
    }
}

