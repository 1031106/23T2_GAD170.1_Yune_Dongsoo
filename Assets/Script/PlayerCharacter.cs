using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Variables will go first
    [SerializeField] private int attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;
    [SerializeField] private int EXP = 1;

    // We need our player character to attack when we press the spacebar...
    // but let's simply get it to add a level for now.

    // Start is called before the first frame update
    void Start()
    {
        attack = 10;
        health = 100;
        level = 1;
        StartTheGameAgainFromLevelOne();
    }

    // Update is called once per frame
    void Update()
    {
        // if the player presses the spacebar...
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("Dongsoo has hit the spacebar on my computer at the front of the room!");
        level++;

    if(level == 5)
        
        Debug.Log("Win");
    }
    
    
    public void StartTheGameAgainFromLevelOne()
    {
        attack = 10;
        health = 100;
        level = 1;
    }
    
}
