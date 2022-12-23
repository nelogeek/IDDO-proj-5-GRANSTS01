using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class Сutter : MonoBehaviour
{
    public GameObject prfabCutter;
    public GameObject CurrentCutter;

    int indexCutter;
    Vector3 cutterPos;

    void Start()
    {
        cutterPos = CurrentCutter.transform.position;
        CurrentCutter = null;
        indexCutter = 0;
    }

    void Update()
    {
        // Move cutter
        if (CurrentCutter != null)
        {
            if (CurrentCutter.transform.position.z <= this.transform.position.z)
            {
                cutterPos.z = this.transform.position.z;
            }

            if (CurrentCutter.transform.position.y >= this.transform.position.y)
            {
                cutterPos.y = this.transform.position.y;
            }

            CurrentCutter.transform.position = cutterPos;
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
        // Create new cutter after enter
        CurrentCutter = Instantiate(prfabCutter, this.transform.position, Quaternion.Euler(0,0,-90));
        CurrentCutter.transform.parent = GameObject.Find("Template").transform;
        cutterPos.x = this.transform.position.x;

        indexCutter++;
        CurrentCutter.name = "Cutter № " + indexCutter;
    }

    private void OnTriggerExit(Collider other)
    {
        // put cutter after exit
        CurrentCutter = null;        
    }
}
