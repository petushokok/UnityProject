using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class RandomB : MonoBehaviour
{
    private int RandText1;
    private int RandText2;
    [SerializeField] private TMP_Text R1, R2;
    public TMP_InputField prois;
    public GameObject button;
    public void RandomNumb()
    {
        RandText1 = Random.Range(2, 10);
        R1.text = RandText1.ToString() + " * ";
        RandText2 = Random.Range(2, 10);
        R2.text = RandText2.ToString() +  " = ";
       
    }
    public void Result()
    {
        int p, a, b,c;
        p = int.Parse(prois.text);
        a = RandText1;
        b = RandText2;
        c = a * b;
        if  (c == p)
        {
            gameLogic.score += 1;
            Destroy(button);
            
        }
        
    }

}
