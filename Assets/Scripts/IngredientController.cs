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

    private int milk;
    private int cheese;
    private int egg;

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
            milk = 2;
            cheese = 2;
            egg = 3;

            for(int i = 0; i < milk; i++)
            {
                levelOne();
                Instantiate(milkObj, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
            }
        }
        
    }

    public void levelOne()
    {
        float xPos = Random.Range(-10, 10);
        Debug.Log(xPos);
        float zPos = Random.Range(-10, 10);
        Debug.Log(zPos);

        transform.position = new Vector3(xPos, 1, zPos);
    }
}
