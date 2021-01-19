using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public int deckSize;
    // Random rnd = new Random();
    public Dictionary<string, int> currentDeck;
    private string[] suit = {
        "Hearts",
        "Diamonds",
        "Spades",
        "Clovers",
        "Joker",
    };
    

    void Start()
    {
        deckSize = 54;
    }

    // Update is called once per frame
    void Update()
    {
        shuffleDeck();
    }
    void shuffleDeck()
    {
        for(int i = 0; i< deckSize; i++)
        {
            int getSuit = Random.Range(1, 6);
            int getNum = Random.Range(1,14);

            if (getSuit == 1)
            {

            }
            else if (getSuit == 2)
            {

            }
            else if (getSuit == 3)
            {

            }
            else if (getSuit == 4)
            {

            }
            else if (getSuit == 5)
            {
                
            }
            currentDeck[getSuit] = getNum;
            print(currentDeck);
        }
    }
}
