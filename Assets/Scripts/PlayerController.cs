using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Vincent, Scruggs
   April 25, 2024
Player controller
*/
public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    public int currentLevel;
    public int milkGathered;
    public int score;

    public IngredientController ingredientController;

    private void Start()
    {
        score = 0;
        milkGathered = 0;
        currentLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        //Check if player is moving left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Milk>())
        {
            if (ingredientController.milkNeeded > milkGathered)
            {
                Destroy(collision.gameObject);
                milkGathered++;
                score += 10;
            }
            else if (ingredientController.milkNeeded == 0)
            {
                //score -= 5;
                Destroy(collision.gameObject);
            }
            else if(ingredientController.milkNeeded == milkGathered)
            {
                //score -= 5;
                Destroy(collision.gameObject);

            }
        }
    }
    

}

