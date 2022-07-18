using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoUI;
    [SerializeField] int initialScore;
    [SerializeField] UnityEvent invoke1;
    [SerializeField] UnityEvent invoke2;
    [SerializeField] UnityEvent invoke3;


    public void UpdateScore(int n)
    {
        initialScore += n;
        // initialScore = initialScore + n;
        textoUI.text = "Coins: "+ initialScore;
    }

    public void InvokeChar1()
    {
        if (initialScore >= 5)
        {
            initialScore -= 5;
            invoke1?.Invoke();
            UpdateScore(0);
        }
    }
    public void InvokeChar2()
    {
        if (initialScore >= 7)
        {
            initialScore -= 7;
            invoke2?.Invoke();
            UpdateScore(0);
        }
    }
    public void InvokeChar3()
    {
        if (initialScore >= 10)
        {
            initialScore -= 10;
            invoke3?.Invoke();
            UpdateScore(0);
        }
    }

}
