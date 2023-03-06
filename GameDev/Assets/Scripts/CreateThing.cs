using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateThing : MonoBehaviour
{
    [SerializeField] int seven = 3;
    [SerializeField] GameObject ven;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ven != null)
        {
            seven = 4;
        Debug.Log(seven);
        }
    }
}
