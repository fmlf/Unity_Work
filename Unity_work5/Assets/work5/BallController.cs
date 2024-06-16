using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallController : MonoBehaviour
{
    public float speed = 5f;//공의 움직임 속도
    private Rigidbody rb;
    private ScoreManager scoreManager;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");//수평입력 방향키나, A/D키 가져옴
        
        Vector3 movement = new Vector3(moveHorizontal,0.0f,0.0f);//움직임 벡터 생성
        rb.AddForce(movement*speed);//공 움직임
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("PickUp")){
            other.gameObject.SetActive(false);
            scoreManager.AddScore(1);//점수 획득
        }
        else if(other.gameObject.CompareTag("Penalty")){
            other.gameObject.SetActive(false);//오브젝트 비활성화
            scoreManager.AddScore(-1);//감점
        }
    
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ground")){
            Debug.Log("Ball hit the ground");
            gameObject.SetActive(false);//공이 바닥에 닿으면 사라짐
        }
    }
}

