using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToMainMenu : MonoBehaviour
{
    
    public void GoToMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}
