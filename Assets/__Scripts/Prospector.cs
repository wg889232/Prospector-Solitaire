﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Prospector : MonoBehaviour
{
    static public Prospector S;

    public TextAsset deckXML;
    
    [Header("Set Dynamically")]
    public Deck deck;

    void Awake()
    {
        S = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        deck = GetComponent<Deck>();
        deck.InitDeck(deckXML.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
