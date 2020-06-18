using UnityEngine;
using System.Collections;

public class RestartOrQuit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    //// Update is called once per frame
    //public void ChangeToScene(string LoadLevel)
    //{
    //    Application.LoadLevel(0);
    //}
    public void Exit()
    {
        Application.Quit();
    }
}