using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB3 : MonoBehaviour, IVirtualButtonEventHandler
{
    public Rigidbody ball;
    public GameObject vbutton;
    public int force = 80;

    // Start is called before the first frame update
    void Start()
    {
        vbutton = GameObject.Find("VirtualButton 3");
        vbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ball.AddForce(new Vector3(force, 0, 0));
        Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
