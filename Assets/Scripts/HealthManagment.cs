using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthManagment : MonoBehaviour
{
    public int healthPoints;
    int maxHealth;
    float fullBarLenght;
    float barHeight;
    public int invicibilityfarmes;
    int invicibilityfarmesCounter;

    public GameObject healthText;
    public GameObject healthJuice;

    void Start()
    {
        maxHealth = healthPoints;
        fullBarLenght = healthJuice.GetComponent<RectTransform>().sizeDelta.x;
        barHeight = healthJuice.GetComponent<RectTransform>().sizeDelta.y;
    }

    public void damage()
    {
        if (invicibilityfarmesCounter > invicibilityfarmes)
        {
            healthPoints -= 1;
            invicibilityfarmesCounter = 0;
        }

    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag!= "Untagged")
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Obsticle" && invicibilityfarmesCounter>invicibilityfarmes)
        {
            damage();
        }
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag +" "+ invicibilityfarmesCounter);
        if (other.gameObject.tag == "Obsticle" && invicibilityfarmesCounter > invicibilityfarmes)
        {
            damage();
        }
    }

    // Update is called once per frame
    void Update()
    {
        invicibilityfarmesCounter++;
        healthText.GetComponent<Text>().text = "HEALTH POINTS: " + healthPoints;
        Vector2 vector = new Vector2(fullBarLenght * ((float)healthPoints / (float)maxHealth),barHeight);
        healthJuice.GetComponent<RectTransform>().sizeDelta = vector;
    }
}
