using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMan : MonoBehaviour {
    //Create Public verrables (Game object)
   public GameObject player;
   public GameObject mainMenu;

    //private Boolean onStartGamerSelection;


	// Use this for initialization
	void Start () {
        player.SetActive(false);
        mainMenu.SetActive(true);



	}
	
	// Update is called once per frame
	void Update () {




        if (Input.GetKey("space") || Input.GetKey("enter"))
        {
            player.SetActive(true);
            mainMenu.SetActive(false);
        }
        // if player presses up move the seletion up

        //if the player presses down move the selection down

        // if the player presses space and over start start the game

        //if the player presses space on player selecter change the number

    }
}
