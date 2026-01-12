using UnityEngine;
using TMPro;

public class BestTimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI bestTimeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float best = PlayerPrefs.GetFloat("BestTime", -1f);
        if (best < 0f)
        {
            bestTimeText.text = "Best Time: --";
        }
        else
        {
            bestTimeText.text = "Best Time: " + best.ToString("F2");
        }
    }
}
