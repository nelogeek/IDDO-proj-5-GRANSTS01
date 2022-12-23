using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static bool isPaused = false;
    public static bool isStopedController = false;
    public static bool lastStayController;// memorize last stay of controller

    public KeyCode KeyContinue = KeyCode.Escape;
    public KeyCode KeyManual = KeyCode.F1;
    public KeyCode KeyExit = KeyCode.F10;
    public KeyCode KeyStopController = KeyCode.Mouse1;

    public GameObject btn_new_exp;
    public GameObject btn_tbl;

    // Update is called once per frame
    void Update()
    {
        // Hide or Show Menu
        if (Input.GetKeyDown(KeyContinue))
        {
            if (isPaused)
            {
                isPaused = false;
                isStopedController = lastStayController;
                btn_new_exp.SetActive(false);
                btn_tbl.SetActive(false);
            }
            //else
            //{
            //    lastStayController = isStopedController;
            //    isPaused = true;
            //    isStopedController = true;
            //    btn_new_exp.SetActive(false);
            //    btn_tbl.SetActive(false);
            //
            //}
        }

        // Stop Controller
        if (!isPaused)
        {
            if (Input.GetKeyDown(KeyStopController))
            {
                if (isStopedController)
                {
                    isStopedController = false;
                    

                }
                else
                {
                    isStopedController = true;
                    
                }
            }
        }

        // Open Manual
        if (Input.GetKeyDown(KeyManual))
        {

        }
    }
}
