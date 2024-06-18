using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasadorObjetos : MonoBehaviour
{
    public GameObject[] objetos;
    public int Index = 10;


    void Start()
    {
        DeactivateAll();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivatePrevious();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActivateNext();
        }
    }

    public void ActivateNext()
    {
        Index++;
        if (Index >= objetos.Length)
        {
            Index = 0;

        }

        DeactivateAll();
        objetos[Index].SetActive(true);
    }

    public void ActivatePrevious()
    {
        Index--;
        if (Index < 0)
        {
            Index = objetos.Length - 1;
        }
        DeactivateAll();
        objetos[Index].SetActive(true);
    }

    void DeactivateAll()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }



}


