using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize time text to initial time
        timeText.text = Time.time.ToString() + "s";
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }

    void UpdateTime()
    {
        //Update time text by elapsed time
        timeText.text = string.Format("{0:F1}", Time.time) + "s";
            
    }
}
