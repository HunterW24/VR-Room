using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject screen;
    public GameObject reset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UiDisappear()
    {
        screen.SetActive(false);
    }

    public void ResetSwitch()
    {
        reset.SetActive(true);
    }
}
