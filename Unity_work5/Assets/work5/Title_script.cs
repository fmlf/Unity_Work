using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Title_script : MonoBehaviour
{
    [SerializeField] Button btnTitle;
    // Start is called before the first frame update
    void Start()
    {
        btnTitle.onClick.AddListener(()=>{
            SceneManager.LoadScene("start");//버튼을 누르면 타이틀 화면으로 돌아감
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
