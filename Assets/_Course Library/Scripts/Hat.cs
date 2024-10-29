using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Unity.VisualScripting;
using UnityEngine;

public class Hat : MonoBehaviour
{

    public GameObject toolTip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HatToolTips()
    {
        toolTip.SetActive(true);
    }

    public void HatToolTipsDeactivate()
    {
        toolTip.SetActive(false);
    }
}
