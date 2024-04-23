using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float timeLeft = 90f;
    public GameObject timeCounter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;


        UpdateUI();
    }
    void UpdateUI()
    {
        //funkcja odpowiedzialna za aktualizacje interfejsu uzytkownika

        timeCounter.GetComponent<TextMeshProUGUI>().text = "Time:" + Mathf.Floor(timeLeft).ToString();
    }
}
