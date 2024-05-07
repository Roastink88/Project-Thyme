using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    private float oneTime = 30f;
    private float twoTime = 25f;
    private float threeTime = 20f;
    private float fourTime = 15;

    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator levelTimer()
    {
        if(playerController.currentLevel == 1)
        {
            yield return new WaitForSeconds(oneTime);
        }
        else if (playerController.currentLevel == 2)
        {
            yield return new WaitForSeconds(twoTime);
        }
        else if (playerController.currentLevel == 3)
        {
            yield return new WaitForSeconds(threeTime);
        }
        else if (playerController.currentLevel == 4)
        {
            yield return new WaitForSeconds(fourTime);
        }
    }
}
