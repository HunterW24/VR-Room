using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateShapePrefabs : MonoBehaviour
{
    public Slider rotationSlider; // Reference to the UI Slider
    public GameObject pedestal;

    void Start()
    {
        // Assuming the Slider's initial value is 0
        rotationSlider.onValueChanged.AddListener(RotateShapes);
    }

    public void Update()
    {
        float rotationAngle = rotationSlider.value * 180f; // Adjust the multiplier if needed
        pedestal.transform.rotation = Quaternion.Euler(0f, rotationAngle, 0f);
    }

    void RotateShapes(float value)
    {
        // Find all GameObjects with the tag "Shape"
        GameObject[] shapeObjects = GameObject.FindGameObjectsWithTag("Shape");

        // Iterate through each shape object
        foreach (GameObject shapeObject in shapeObjects)
        {
            // Get the Rigidbody component
            Rigidbody rb = shapeObject.GetComponent<Rigidbody>();

            // Rotate the Rigidbody around the Y-axis
            rb.angularVelocity = new Vector3(0f, rotationSlider.value , 0f); // Adjust the multiplier as needed
        }
    }
}