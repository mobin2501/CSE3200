using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class St : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(Next);
    }
    void Next()
    {
        SceneManager.LoadScene(2);
    }
}
