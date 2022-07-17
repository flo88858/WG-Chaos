using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoadScene : MonoBehaviour
{
    public TMP_Text text;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LadSzene(string szene)
    {
        SceneManager.LoadScene(szene);
    }

    public void Test()
    {
        text.text = "Wir alle mögen Kugelfische";
    }
}
