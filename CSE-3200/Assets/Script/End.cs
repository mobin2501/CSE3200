using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(Exit);
    }
    void Exit()
    {
        Application.Quit();
    }
}
