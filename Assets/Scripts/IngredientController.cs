using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientController : MonoBehaviour
{
    private Vector3 itemPos;

    public int itemPerLevel;

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
        levelOne();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Creates the bounderies for level 1 ingredient spawning
    /// </summary>
    public void levelOne()
    {
        milkNeeded = 1;
        cheeseNeeded = 3;
        eggNeeded = 2;

        for (int i = -2; i < milkNeeded; i++)
        {
            float xPos = Random.Range(-9f, 9f);
            //Debug.Log(xPos);
            float zPos = Random.Range(-9f, 9f);
            //Debug.Log(zPos);

            //moves the spawner to the area where the ingredients will be spawned
            transform.position = new Vector3(xPos, 1.25f, zPos);

            //spawns the ingredient
            Instantiate(milkObj, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        }
    }

    /// <summary>
    /// Creates the bounderies for level 2 ingredient spawning
    /// </summary>
    public void levelTwo()
    {
        //moves the ingredient controller to the next level
        transform.position = new Vector3(0, 31.25f, 0);

        milkNeeded = 2;
        cheeseNeeded = 2;
        eggNeeded = 4;

        for (int i = -2; i < milkNeeded; i++)
        {
            float xPos = Random.Range(-14f, 14f);
            //Debug.Log(xPos);
            float zPos = Random.Range(-14f, 14f);
            //Debug.Log(zPos);

            //moves the spawner to the area where the ingredients will be spawned
            transform.position = new Vector3(xPos, 31.25f, zPos);

            //spawns the ingredient
            Instantiate(milkObj, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        }
    }

    /// <summary>
    /// Creates the bounderies for level 3 ingredient spawning
    /// </summary>
    public void levelThree()
    {
        //moves the ingredient controller to the next level
        transform.position = new Vector3(0, 61.25f, 0);

        milkNeeded = 4;
        cheeseNeeded = 1;
        eggNeeded = 6;

        for (int i = -2; i < milkNeeded; i++)
        {
            float xPos = Random.Range(-19f, 19f);
            //Debug.Log(xPos);
            float zPos = Random.Range(-19f, 19f);
            //Debug.Log(zPos);

            //moves the spawner to the area where the ingredients will be spawned
            transform.position = new Vector3(xPos, 61.25f, zPos);

            //spawns the ingredient
            Instantiate(milkObj, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        }
    }

    /// <summary>
    /// Creates the bounderies for level 4 ingredient spawning
    /// </summary>
    public void levelFour()
    {
        //moves the ingredient controller to the next level
        transform.position = new Vector3(0, 91.25f, 0);

        milkNeeded = 6;
        cheeseNeeded = 5;
        eggNeeded = 2;

        for (int i = -2; i < milkNeeded; i++)
        {
            float xPos = Random.Range(-24f, 24f);
            //Debug.Log(xPos);
            float zPos = Random.Range(-24f, 24f);
            //Debug.Log(zPos);

            //moves the spawner to the area where the ingredients will be spawned
            transform.position = new Vector3(xPos, 91.25f, zPos);

            //spawns the ingredient
            Instantiate(milkObj, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        }
    }
}
