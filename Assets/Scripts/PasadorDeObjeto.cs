using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasadorDeObjeto : MonoBehaviour
{
    public GameObject[] objetos;
    public int currentIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            currentIndex++;
            if (currentIndex < objetos.Length)
            {
                ActivateByIndex(currentIndex);
            }
            if (currentIndex > objetos.Length - 1)
            {
                currentIndex = -1;
                DeactivateAll();
            }
        }
    }

    void DeactivateAll()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }

    void ActivateByIndex(int index)
    {
        objetos[index].SetActive(true);
    }

}

