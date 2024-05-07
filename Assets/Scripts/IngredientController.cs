using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientController : MonoBehaviour
{
    private Vector3 itemPos;

    public int itemPerLevel;
    public int levelNow;

    public GameObject milkObj;
    public GameObject cheeseObj;
    public GameObject eggObj;

    public PlayerController playerController;

    public int milkNeeded;
    public int cheeseNeeded;
    public int eggNeeded;

    // Start is called before the first frame update
    void Start()
    {
        levelNow = playerController.currentLevel;
        //Instantiate(milkObj, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        spawnIngredient();
    }

    // Update is called once per frame
    void Update()
    {
        //gets the current level from the player
        levelNow = playerController.currentLevel;
    }

    public void spawnIngredient()
    {
        if (levelNow == 1)
        {
            milkNeeded = 2;
            cheeseNeeded = 2;
            eggNeeded = 3;

            for(int i = 0; i < milkNeeded; i++)
            {
                levelOne();
                Instantiate(milkObj, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
            }
        }
        
    }

    public void levelOne()
    {
        float xPos = Random.Range(-9f, 9f);
        Debug.Log(xPos);
        float zPos = Random.Range(-9f, 9f);
        Debug.Log(zPos);

        transform.position = new Vector3(xPos, 1, zPos);
    }
}
