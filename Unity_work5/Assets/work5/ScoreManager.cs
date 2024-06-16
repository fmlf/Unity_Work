using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // TextMeshPro UGUI 텍스트 컴포넌트를 참조
    public int score;  // 점수를 저장하는 정적 변수

    void Awake()
    {
        score = 0;  // 초기 점수를 0으로 설정
        UpdateScoreText();  // 초기 점수를 텍스트에 반영
    }
    
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();  // 점수를 추가
    }

    public void SubtractScore(int value){
        score -= value;
        UpdateScoreText();
    }


    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();  // 점수를 텍스트로 표시
    }
}