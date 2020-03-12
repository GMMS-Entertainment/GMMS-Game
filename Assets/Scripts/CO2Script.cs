using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CO2Script : MonoBehaviour
{
    private TextMeshProUGUI CO2;
    private int percent;

    // Start is called before the first frame update
    void Start()
    {
        CO2 = GetComponent<TextMeshProUGUI>();
        percent = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CO2.text = percent.ToString() + "%";

        if (percent < 100)
        {
            percent++;
        }
    }
}
