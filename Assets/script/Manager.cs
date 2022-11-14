using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Timeline;

public class Manager : MonoBehaviour
{
    
    public List<GameObject> listCardPlayerOne = new List<GameObject>();
    public List<GameObject> listCardCreatedPlayerOne = new List<GameObject>();
    public List<GameObject> listCardPlayerTwo = new List<GameObject>();
    public List<GameObject> listCardCreatedPlayerTwo = new List<GameObject>();
    
    
    void Start() {
        FillJOne();
       FillJTwo();
    }
    
    public void FillJOne() {
        listCardCreatedPlayerOne = new List<GameObject>();
        for (int i = 0; i < 11; i++) {
            listCardCreatedPlayerOne.Add(Instantiate(listCardPlayerOne[i]) as GameObject);
        }
    }
    public void FillJTwo() {
        listCardCreatedPlayerTwo = new List<GameObject>();
        for (int i = 0; i < 11; i++) {
            listCardCreatedPlayerTwo.Add(Instantiate(listCardPlayerTwo[i]) as GameObject);
        }
    }
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.A)) {
            EntityPlayableCard entityPlayableCard = new EntityPlayableCard();
            entityPlayableCard.UpdateHealth();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            ActionCard actionCard = new ActionCard();
            actionCard.Action(this);
        }
    }
}