using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void quit()
    {
        Debug.Log("El joc s'està tancant");
        Application.Quit();
    }
    
        
    
}
