using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


/// <summary>
/// Need to add a points variable to player controller first before continuing.
/// </summary>


public class UI : MonoBehaviour
{
    public PlayerController playerController;
    public TMP_Text points;
    public TMP_Text milk;
    public TMP_Text sauce;
    public TMP_Text pasta;

    void Start()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Milk>())
        {
            milk.text = "<s>" + milk.text + "<s>";
            Destroy(collision.gameObject);
        }
    }
    
}
