using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TMP_Text collectiblesNumbersText;

    private int collectiblesNumber = 0;

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void AddCollectible(){
        collectiblesNumber++;
        collectiblesNumbersText.text = collectiblesNumber.ToString();
    }
}
