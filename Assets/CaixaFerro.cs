using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaFerro : MonoBehaviour
{
    public bool check;
    public GameObject Minerio_ferro;



    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (Input.GetKey(KeyCode.Space))
            {
                Minerio_ferro.SetActive(true);
            }

        }
    }


}
