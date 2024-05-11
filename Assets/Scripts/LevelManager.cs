using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    private int levelTimerTime = 35;
    private int permTime;
    private int istg;

    public PlayerController playerController;
    public IngredientController ingredientController;

    public TMP_Text countdownText;

    Coroutine ti;

    // Start is called before the first frame update
    void Start()
    {
        istg = 0;
        permTime = levelTimerTime;
        StartCoroutine(LevelTimer());
        countdownText.text = levelTimerTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator LevelTimer()
    {
        //creates the countdown based off of the permTime
        for(int i = levelTimerTime += 1; i != 0; i--)
        {
            levelTimerTime--;
            //Debug.Log(levelTimerTime);
            yield return new WaitForSeconds(1);
            countdownText.text = levelTimerTime.ToString();

            if(playerController.milkGathered >= ingredientController.milkNeeded 
                && playerController.cheeseGathered >= ingredientController.cheeseNeeded 
                && playerController.eggGathered >= ingredientController.eggNeeded)
            {
                levelSwitcher();
                yield break;
            }
        }
        levelSwitcher();
    }


    public void levelSwitcher()
    {
        istg++;
        levelTimerTime = permTime;
        if (playerController.currentLevel == 1 && istg == 1)
        {
            //Spawn objects on the next level
            ingredientController.levelTwo();
            //move player to level 2
            playerController.levelTwoStart();
            //lessen the perm time so that each level gets harder
            levelTimerTime -= 5;
            StartCoroutine(LevelTimer());
        }
        else if (playerController.currentLevel == 2 && istg == 2)
        {
            //spawn objects on the next level
            ingredientController.levelThree();
            //move to level 3
            playerController.levelThreeStart();
            //lessen the perm time so that each level gets harder
            levelTimerTime -= 10;
            StartCoroutine(LevelTimer());
        }
        else if (playerController.currentLevel == 3 && istg == 3)
        {
            //spawn objects on the next level
            ingredientController.levelFour();
            //move to level 4
            playerController.levelFourStart();
            //lessen the perm time so that each level gets harder
            levelTimerTime -= 15;
            StartCoroutine(LevelTimer());
        }
        else if (playerController.currentLevel == 4 && istg == 4)
        {
            // End game
            SceneManager.LoadScene(3);
        }
    }
}
