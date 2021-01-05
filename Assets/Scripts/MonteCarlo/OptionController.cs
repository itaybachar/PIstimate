using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    public Text PPFLabel;
    public Slider PPFSlider; 
    
    public static int PointsPerFrame;

    // Start is called before the first frame update
    void Start()
    {
        PointsPerFrame = (int)PPFSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        PointsPerFrame = (int)PPFSlider.value;
        PPFLabel.text = PointsPerFrame.ToString();
    }
}
