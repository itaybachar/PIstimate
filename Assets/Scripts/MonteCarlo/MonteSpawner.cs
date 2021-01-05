using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonteSpawner : MonoBehaviour
{
    public GameObject InsideCirclePrefab;
    public GameObject OutsideCirclePrefab;
    public Text PiLabel;
    public Text PointsLabel;

    int maxSpawnAmount = 10000;
    float radius;

    int totalPoints;
    int circlePoints;

    // Start is called before the first frame update
    void Start()
    {
        radius = Camera.main.orthographicSize+0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            for(int i = 0; i<OptionController.PointsPerFrame;i++)
            {
                totalPoints++;
                Vector2 pos = new Vector2(Random.Range(-radius,radius),Random.Range(-radius,radius));
                if(pos.magnitude<radius)
                {
                    circlePoints++;
                     if(totalPoints<maxSpawnAmount)
                         Instantiate(InsideCirclePrefab,pos,Quaternion.identity);
                }
                else
                {
                     if(totalPoints<maxSpawnAmount)
                         Instantiate(OutsideCirclePrefab,pos,Quaternion.identity);
                }
            }
            PointsLabel.text = totalPoints.ToString();
            PiLabel.text = Estimations.MonteCarloPI(circlePoints,totalPoints).ToString();
        }
    }
}
