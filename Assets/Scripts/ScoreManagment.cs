using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//scriptas kad save pointsus
public class ScoreManagment : MonoBehaviour
{
    int distanceScore;
    int startscore;
    int theScore;
    public int scorePoints;

    public GameObject scoreText;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        theScore = 0;
        startscore = -((int)player.transform.position.z / 5);
    }

    public void addition()
    {
        theScore += scorePoints;
    }

    // Update is called once per frame
    void Update()
    {
        distanceScore = (int)player.transform.position.z / 5;
        int scores = distanceScore + theScore + startscore;
        scoreText.GetComponent<Text>().text = "SCORE: " + scores;
    }
}
