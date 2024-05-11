using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;


/// <summary>
/// Need to add a points variable to player controller first before continuing.
/// </summary>


public class UI : MonoBehaviour
{
    public PlayerController playerController;
    public TMP_Text pointsText;
    public TMP_Text milkText;
    public TMP_Text cheeseText;
    public TMP_Text eggsText;

    public TMP_Text finalText;

    public IngredientController ingredientController;

    void Start()
    {
        
    }

    private void Update()
    {
        pointsText.text = "Score: " + playerController.score.ToString();

        checkIngredient();
        /*if (playerController.milkGathered > ingredientController.milkNeeded)
        {
            milkText.text = "<s>" + milkText.text + "<s>";
        } */
        //finalScore = playerController.score;
        //finalText.text = "FINAL SCORE: " + finalScore;
    }

    /// <summary>
    /// checks and compares how many ingredients the player has gathered compared to how many they need
    /// </summary>
    public void checkIngredient()
    {
        int grabC = playerController.cheeseGathered;
        int needC = ingredientController.cheeseNeeded;

        int grabM = playerController.milkGathered;
        int needM = ingredientController.milkNeeded;

        int grabE = playerController.eggGathered;
        int needE = ingredientController.eggNeeded;

        if (grabC <= needC)
        {
            cheeseText.text = "Cheese: " + grabC + "/" + needC;
        }

        if (grabM <= needM)
        {
            milkText.text = "Milk: " + grabM + "/" + needM;
        }

        if (grabE <= needE)
        {
            eggsText.text = "Eggs: " + grabE + "/" + needE;
        }
    }

    /// <summary>
    /// Resets the text for the shopping list
    /// </summary>
    public void resetNeeded()
    {
        cheeseText.text = "Cheese: " + 0 + "/" + ingredientController.cheeseNeeded;
        milkText.text = "Milk: " + 0 + "/" + ingredientController.milkNeeded;
        eggsText.text = "Eggs: " + 0 + "/" + ingredientController.eggNeeded;
    }

    public void SwitchScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
