using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estimations : MonoBehaviour
{
    //This approach will use the fact that circlePoints/totalPoints = pi/4
    //more generally => (pi*r^2)/(4r^2) => pi/4
    public static double MonteCarloPI(int circlePoints,int totalPoints)
    {
        return 4.0 * ((double)circlePoints/totalPoints);
    }
}
