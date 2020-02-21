using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menustart : MonoBehaviour
{
    // Start is called before the first frame update
   public void changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
