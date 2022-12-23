using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCutter : MonoBehaviour
{
    public Transform headerCutter;

    Vector3 center;
    Vector3 extends;
    Vector3 leftPos;
    Vector3 rightPos;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.localPosition = Vector3.zero;

        center = this.GetComponent<MeshRenderer>().bounds.center;
        extends = this.GetComponent<MeshRenderer>().bounds.extents;

        rightPos = headerCutter.GetComponent<MeshRenderer>().bounds.center;
    }

    // Update is called once per frame
    void Update()
    {
        leftPos =  rightPos - headerCutter.position;

        this.transform.localPosition = leftPos;

        Vector3 scale = new Vector3(1, 2,  Mathf.Abs(this.transform.localPosition.z) * 2);
        this.transform.localScale = scale;
    }

    private void OnDrawGizmos()
    {
        // Left
        Vector3 leftPos = center;
        leftPos.z = center.z + extends.z;
        Gizmos.color = Color.green;
        Gizmos.DrawCube(leftPos, new Vector3(0.1f, 0.1f, 0.1f)); // Left

        // Right
        Vector3 rightPos = center;
        rightPos.z = center.z - extends.z;
        Gizmos.color = Color.red;
        Gizmos.DrawCube(rightPos, new Vector3(0.1f, 0.1f, 0.1f)); // right
    }
}
