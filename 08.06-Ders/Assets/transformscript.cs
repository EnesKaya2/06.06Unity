using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Speed ve Delta Time olmadan D�n�s
        transform.Rotate(transform.forward);
    }
}
