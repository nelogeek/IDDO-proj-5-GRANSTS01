using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(VLRTK.Outline.OutlineObject))]
public class ObjectInformation : MonoBehaviour
{

    public string Name;
    
    // Start is called before the first frame update
    void Start()
    {
        //// Add collider
        //if (this.GetComponent<Collider>() == null)
        //    this.gameObject.AddComponent<MeshCollider>();

        //// Add outline
        //if (this.GetComponent<VLRTK.Outline.OutlineObject>() == null)
        //{
        //    this.gameObject.AddComponent<VLRTK.Outline.OutlineObject>();
        //    //this.gameObject.GetComponent<VLRTK.Outline.OutlineObject>().isActiveOnStart = false;
        //    this.gameObject.GetComponent<VLRTK.Outline.OutlineObject>().onAll = true;
        //}
    }
}
