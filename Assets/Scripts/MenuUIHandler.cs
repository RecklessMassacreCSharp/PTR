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
    public void PickVan() {
        DataManager.Instance.vehicleType = 2;
        SceneManager.LoadScene(1);
    }

    public void PickBus() {
        DataManager.Instance.vehicleType = 0;
        SceneManager.LoadScene(1);
    }

    public void PickCar() {
        DataManager.Instance.vehicleType = 1;
        SceneManager.LoadScene(1);
    }

    public void Exit() {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
