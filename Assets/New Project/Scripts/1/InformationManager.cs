using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InformationManager : MonoBehaviour
{
    [SerializeField] GameObject infoPanel;
    [SerializeField] Text infoText;
    Ray mouseRay;
    RaycastHit mouseHit;
    //public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        HideInfo();
    }

    // Update is called once per frame
    void Update()
    {
        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (!EventSystem.current.IsPointerOverGameObject()) // For block UI raycast
        {
            if (Physics.Raycast(mouseRay, out mouseHit, 100))
            {
                if (mouseHit.collider.GetComponent<ObjectInformation>() != null)
                    ShowInfo(mouseHit.collider.GetComponent<ObjectInformation>().Name);

                else
                    HideInfo();
            }
            else
            {
                HideInfo();
            }
        }
        else
        {
            HideInfo();
        }
    }

    void ShowInfo(string info)
    {

        if (!infoPanel.activeSelf)
        {
            infoPanel.SetActive(true);
        }

        infoText.text = info;
    }

    void HideInfo()
    {
        infoPanel.SetActive(false);
    }

}
