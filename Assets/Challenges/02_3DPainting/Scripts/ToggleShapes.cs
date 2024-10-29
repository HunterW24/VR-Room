using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleShapes : MonoBehaviour
{
    public GameObject cube;
    public GameObject none;
    public GameObject plane;
    public GameObject sphere;
    public GameObject shapes;
    public GameObject choose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cube()
    {
       cube.SetActive(true);
    }

    public void DCube()
    {
        cube.SetActive(false);
    }

    public void None()
    {
        none.SetActive(true);
    }

    public void DNone()
    {
        none.SetActive(false);
    }

    public void Plane()
    {
        plane.SetActive(true);
    }

    public void DPlane()
    {
        plane.SetActive(false );
    }

    public void Sphere()
    {
        sphere.SetActive(true);
    }

    public void DSphere()
    {
        sphere.SetActive(false);
    }

    public void ShapeOn()
    {
        shapes.SetActive(true);
    }

    public void ShapeOff()
    {
        shapes.SetActive(false);
    }

    public void ChooseOn()
    {
        choose.SetActive(true);
    }

    public void ChooseOff()
    {
        choose.SetActive(false);
    }

}
