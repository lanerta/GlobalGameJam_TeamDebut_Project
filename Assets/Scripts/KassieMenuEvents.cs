using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KassieMenuEvents : MonoBehaviour
{
    public void LoadStart(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadMenu(int index)
    {
        SceneManager.LoadScene(index);
    }

    
}
