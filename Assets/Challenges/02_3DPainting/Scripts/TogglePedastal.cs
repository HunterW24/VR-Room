using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePedastal : MonoBehaviour
{
    public GameObject Pedastal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle()
    {
        Pedastal.SetActive(false);
    }
}
