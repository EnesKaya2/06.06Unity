using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float age;
    [SerializeField] private float weight;
    [SerializeField] private bool isStudy;

    // Start is called before the first frame update
    private void Start()
    {
        if (!isStudy)
        {
            if (age == 18 && weight < 100)
            {
                Debug.Log("Askerlik G�revi ��in Cagr�ld�g�n�z");
            }
            else if (age > 18 && weight < 100)
            {
                float delay = age - 18;
                Debug.Log("Askerlik G�revi �cin" + delay + "Y�l Gec Kald�n�z.L�tfen Birlige Teslim Olun");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
