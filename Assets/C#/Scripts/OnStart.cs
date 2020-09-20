using System;
using System.Collections;
using System.Collections.Generic;
using Entities;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[InitializeOnLoad]
public class OnStart : MonoBehaviour
{
    /*
    public GameObject card;
    public Transform hand = GameObject.Find("Table").GetComponent(panel,"Hand") as Transform;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        GameObject[] cards = new GameObject[14]; //TODO: Replace with list
        for (var i = 0; i < 14; i++)
        {
            cards[i] = Instantiate(card);
            cards[i].transform.SetParent(hand);
        }
        Debug.Log("End");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

    private void Start()
    {
        var deck = new Deck();
        deck.Shuffle();
    }
}
