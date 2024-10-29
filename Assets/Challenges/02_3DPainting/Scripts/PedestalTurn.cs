using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PedestalTurn : MonoBehaviour
{
    public Slider rotationSlider;
    public GameObject pedestal;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        float rotationAngle = rotationSlider.value * 180f; // Adjust the multiplier if needed
        pedestal.transform.rotation = Quaternion.Euler(0f, rotationAngle, 0f);
    }
}
