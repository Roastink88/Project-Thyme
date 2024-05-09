using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientController : MonoBehaviour
{
    private Vector3 itemPos;

    public float objectHeight;
    public float levelSize;

    public GameObject milkObj;
    public GameObject cheeseObj;
    public GameObject eggObj;

    public PlayerController playerController;

    public int milkNeeded;
    public int cheeseNeeded;
    public int eggNeeded;

    private float levelSizeInc = 5;
    private float levelHeightInc = 30;

    // Start is called before the first frame update
    void Start()
    {
        levelOne();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnIngredient(float numberOfIngredient, GameObject ingredient, float levelsize)
    {
        for (int i = -2; i < numberOfIngredient; i++)
        {
            float xPos = Random.Range(-levelsize, levelsize);
            //Debug.Log(xPos);
            float zPos = Random.Range(-levelsize, levelsize);
            //Debug.Log(zPos);

            //moves the spawner to the area where the ingredients will be spawned
            transform.position = new Vector3(xPos, objectHeight, zPos);

            //spawns the ingredient
            Instantiate(ingredient, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        }
    }

    /// <summary>
    /// Creates the bounderies for level 1 ingredient spawning
    /// </summary>
    public void levelOne()
    {
        levelSize = 9f;
        objectHeight = 1.25f;

        milkNeeded = 1;
        cheeseNeeded = 3;
        eggNeeded = 2;

        spawnIngredient(milkNeeded, milkObj, levelSize);
        spawnIngredient(eggNeeded, eggObj, levelSize);
        spawnIngredient(cheeseNeeded, cheeseObj, levelSize);
    }

    /// <summary>
    /// Creates the bounderies for level 2 ingredient spawning
    /// </summary>
    public void levelTwo()
    {
        levelSize = levelSize += levelSizeInc;
        objectHeight = objectHeight += levelHeightInc;

        //moves the ingredient controller to the next level
        transform.position = new Vector3(0, objectHeight, 0);

        milkNeeded = 2;
        cheeseNeeded = 2;
        eggNeeded = 4;

        

        spawnIngredient(milkNeeded, milkObj, levelSize);
        spawnIngredient(eggNeeded, eggObj, levelSize);
        spawnIngredient(cheeseNeeded, cheeseObj, levelSize);
    }

    /// <summary>
    /// Creates the bounderies for level 3 ingredient spawning
    /// </summary>
    public void levelThree()
    {
        levelSize = levelSize += levelSizeInc;
        objectHeight = objectHeight += levelHeightInc;

        //moves the ingredient controller to the next level
        transform.position = new Vector3(0, objectHeight, 0);

        milkNeeded = 4;
        cheeseNeeded = 1;
        eggNeeded = 6;

        spawnIngredient(milkNeeded, milkObj, levelSize);
        spawnIngredient(eggNeeded, eggObj, levelSize);
        spawnIngredient(cheeseNeeded, cheeseObj, levelSize);
    }

    /// <summary>
    /// Creates the bounderies for level 4 ingredient spawning
    /// </summary>
    public void levelFour()
    {
        levelSize = levelSize += levelSizeInc;
        objectHeight = objectHeight += levelHeightInc;

        //moves the ingredient controller to the next level
        transform.position = new Vector3(0, objectHeight, 0);

        milkNeeded = 6;
        cheeseNeeded = 5;
        eggNeeded = 2;

        spawnIngredient(milkNeeded, milkObj, levelSize);
        spawnIngredient(eggNeeded, eggObj, levelSize);
        spawnIngredient(cheeseNeeded, cheeseObj, levelSize);
    }
}
