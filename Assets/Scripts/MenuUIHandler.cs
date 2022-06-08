using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
    using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    
    void Start()
    {
        
    }
    /*
    public void PickVan() {
        DataManager.Instance.vehilveType = "Van";
        SceneManager.LoadScene(1);
    }

    public void PickBus() {
        DataManager.Instance.vehilveType = "Bus";
        SceneManager.LoadScene(1);
    }

    public void PickPlane() {
        DataManager.Instance.vehilveType = "Plane";
        SceneManager.LoadScene(1);
    }

    public void Exit() {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
    */

}
