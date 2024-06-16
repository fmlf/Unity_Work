using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class camera_script : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public GameObject ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;//카메라와 공 사이의 거리 계산
        offset = transform.position - ScoreText.transform.position;//카메라와 점수텍스트 사이 거리계산
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position+offset;//프레임마다 공 위치에 offset더해서 카메라 위치 업데이트
        transform.position = ScoreText.transform.position+offset;//프레임마다 점수텍스트 위치에 offset더해서 카메라 위치 업데이트
    }
}
