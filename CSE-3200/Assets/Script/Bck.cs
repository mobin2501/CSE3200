using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bck : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(Back);
    }
    
    void Back()
    {
        SceneManager.LoadScene("Game2");
    }
}
