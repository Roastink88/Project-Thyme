using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


/// <summary>
/// Need to add a points variable to player controller first before continuing.
/// </summary>


public class UI : MonoBehaviour
{
    public PlayerController playerController;
    public TMP_Text points;
    public TMP_Text milk;
    public TMP_Text cheese;
    public TMP_Text eggs;

    public int milkGathered;
    public int score;

    public IngredientController ingredientController;

    void Start()
    {
        

    }

    private void Update()
    {
        points.text = "Points: " + playerController.score.ToString();

        if (playerController.milkGathered > ingredientController.milkNeeded)
        {
            milk.text = "<s>" + milk.text + "<s>";
        }
    }

    

   
   /* public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Milk>())
        {
            if (ingredientController.milkNeeded != 0 && ingredientController.milkNeeded < milkGathered)
            {
                print("test");

                milkGathered++;
                score += 10;
                Destroy(collision.gameObject);
                milk.text = "<s>" + milk.text + "<s>";
            }
            
            else if (ingredientController.milkNeeded == milkGathered)
            {
                Destroy(collision.gameObject);
            }
        }
    }
   */
}
