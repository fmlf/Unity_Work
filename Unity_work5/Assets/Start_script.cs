using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start_script : MonoBehaviour
{
    [SerializeField] TMP_Text textLabel1;
    [SerializeField] Button btnStart;
    // Start is called before the first frame update
    void Start()
    {
        btnStart.onClick.AddListener(
            ()=>{
                textLabel1.text = "Start";
                SceneManager.LoadScene("work5");//Start버튼을 누르면 게임씬으로 넘어감
            }
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
