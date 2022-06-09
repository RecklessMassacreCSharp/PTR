using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneUIHandler : MonoBehaviour
{
    public void ExitToMenu() { 
        SceneManager.LoadScene(0);
    }
}
