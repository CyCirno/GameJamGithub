using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("MyLoadingFunction", 8f);
    }
    void MyLoadingFunction()
    {
        SceneManager.LoadScene(0);
    }
}
