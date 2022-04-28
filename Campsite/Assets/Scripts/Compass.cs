using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public GameObject Dial;
    public float DialSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Dial.transform.eulerAngles = Vector3.Lerp(Dial.transform.eulerAngles, Vector3.forward, Time.deltaTime * DialSpeed);
        Dial.transform.rotation = Quaternion.Slerp(Dial.transform.rotation, Quaternion.Euler(0, 0, 1), Time.deltaTime * DialSpeed);


        Dial.transform.localEulerAngles = new Vector3(0, 0, Dial.transform.localEulerAngles.z);
    }
}
