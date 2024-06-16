using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quit_script : MonoBehaviour
{
    [SerializeField] TMP_Text textLabel1;
    [SerializeField] Button btnQuit;
    // Start is called before the first frame update
    void Start()
    {
        btnQuit.onClick.AddListener(()=>{
            textLabel1.text = "Quit";
            Application.Quit();//Quit버튼을 누르면 프로그램이 종료됨
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
