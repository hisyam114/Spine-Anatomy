using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class CategoryBtnScript : MonoBehaviour
// {
//     [SerializeField] private Text categoryTitleText;
//     [SerializeField] private Text scoreText;
//     [SerializeField] private Button btn;

//     public Button Btn { get => btn; }
//     public Image fill;
//     public TextMeshPro amount;
//     public int currentValue, maxValue;
//     void Start()
//     {
//         fill.fillAmount = Normalise();
//         amount.text = $"{currentValue}/{maxValue}";
//     } 
//     private float Normalise()
//     {
//         return (float)currentValue / maxValue;
//     }
//     public void 
//     public void SetButton(string title, int totalQuestion)
//     {
//         categoryTitleText.text = title;
//         scoreText.text = PlayerPrefs.GetInt(title, 0) + "/" + totalQuestion; //we get the score save for this category
//     }

// }
{
    [SerializeField] private Text categoryTitleText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Button btn;

    public Button Btn { get => btn; }

    public void SetButton(string title, int totalQuestion)
    {
        categoryTitleText.text = title;
        scoreText.text = PlayerPrefs.GetInt(title, 0) + "/" + totalQuestion; //we get the score save for this category
    }

}
