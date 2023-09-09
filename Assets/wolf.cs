using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolf : MonoBehaviour
{
    public Animation run;
    public GameObject  Wolfmesh;
    public GameObject ButtonSystem;
    // Start is called before the first frame update
    void Start()
    {
        
        var cont = gameObject.GetComponent<Animator>();
        cont.Play(0);
        ButtonSystem = GameObject.FindWithTag("button_system");
        Wolfmesh = GameObject.FindWithTag("mesh");
        ButtonSystem.GetComponent<ButtonEventController>().ini();
        
    }

    // Update is called once per frame
    void Update()
    {
        Wolfmesh.transform.Rotate(0,0.3f,0);
    }
}
