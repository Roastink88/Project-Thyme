using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float floor = 1.25f;
    public float floorInc = 30f;

    public int currentLevel;
    public int score;
    public int scoreIncrement = 10;

    public IngredientController ingredientController;
    public LevelManager levelManager;

    private Vector3 startPos;

    private int milkGathered;
    private int eggGathered;
    private int cheeseGathered;

    private void Start()
    {
        startPos = transform.position;
        score = 0;
        milkGathered = 0;
        currentLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //moves the player with either WASD or the Arrow Keys
    public void Move()
    {
        //Moves the player left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        //moves the player right
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        //moves the player up
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        //moves the player down
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }

    //controlls player's collisions with different ingredients
    private void OnCollisionEnter(Collision collision)
    {
        //Player collides with Milk
        if (collision.gameObject.GetComponent<Milk>())
        {
            //Correct ingredient grabbed and correct ammount
            if (ingredientController.milkNeeded > milkGathered)
            {
                Destroy(collision.gameObject);
                milkGathered++;
                score += scoreIncrement;
            }
            //Wrong ingredient grabbed
            else if (ingredientController.milkNeeded == 0)
            {
                score -= scoreIncrement/2;
                Destroy(collision.gameObject);
            }
            //Too much of ingredient is grabbed
            else if(ingredientController.milkNeeded <= milkGathered)
            {
                score -= scoreIncrement / 2;
                Destroy(collision.gameObject);

            }
        }
        else if (collision.gameObject.GetComponent<Egg>())
        {
            //Correct ingredient grabbed and correct ammount
            if (ingredientController.eggNeeded > eggGathered)
            {
                Destroy(collision.gameObject);
                eggGathered++;
                score += scoreIncrement;
            }
            //Wrong ingredient grabbed
            else if (ingredientController.eggNeeded == 0)
            {
                score -= scoreIncrement / 2;
                Destroy(collision.gameObject);
            }
            //Too much of ingredient is grabbed
            else if (ingredientController.eggNeeded <= eggGathered)
            {
                score -= scoreIncrement / 2;
                Destroy(collision.gameObject);

            }
        }
        else if (collision.gameObject.GetComponent<Cheese>())
        {
            //Correct ingredient grabbed and correct ammount
            if (ingredientController.cheeseNeeded > cheeseGathered)
            {
                Destroy(collision.gameObject);
                cheeseGathered++;
                score += scoreIncrement;
            }
            //Wrong ingredient grabbed
            else if (ingredientController.cheeseNeeded == 0)
            {
                score -= scoreIncrement / 2;
                Destroy(collision.gameObject);
            }
            //Too much of ingredient is grabbed
            else if (ingredientController.cheeseNeeded <= cheeseGathered)
            {
                score -= scoreIncrement / 2;
                Destroy(collision.gameObject);

            }
        }
        else if (collision.gameObject.GetComponent<Thyme>())
        {
            score += scoreIncrement * 5;
            Destroy(collision.gameObject);
        }
    }

    //Resets player position to accomodate for level two and sets current level
    public void levelTwoStart()
    {
        transform.position = new Vector3(0, 31.25f, 0);
        currentLevel = 2;
    }

    //Resets player position to accomodate for level three and sets current level
    public void levelThreeStart()
    {
        transform.position = new Vector3(0, 61.25f, 0);
        currentLevel = 3;
    }

    //Resets player position to accomodate for level four and sets current level
    public void levelFourStart()
    {
        transform.position = new Vector3(0, 91.25f, 0);
        currentLevel = 4;
    }
}

