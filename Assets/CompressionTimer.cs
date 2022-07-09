using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Oculus.Interaction; 

public class CompressionTimer : MonoBehaviour
{

    int pressCount;
    float time;
    float predictedCount;

    [SerializeField] TextMeshPro countText;
    //[SerializeField] TextMeshPro countPerMinuteText;

    Oculus.Interaction.ActiveStateTracker s;

    private bool _selected;

    // Start is called before the first frame update
    void Start()
    {
        s.getPressCount();
        time = 0;
        predictedCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (_selected)
        {
            s.addPressCount();
            time += 1 * Time.deltaTime;
        }

        pressCount++;
        countText.text = (pressCount/20).ToString();

        //predictedCount = (pressCount/20) * (60 / time);
        //countPerMinuteText.text = predictedCount.ToString();
    }


}
