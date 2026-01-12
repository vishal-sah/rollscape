using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timerElapsed;

    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        timerElapsed += Time.deltaTime;
        timerText.text = "Time: " + timerElapsed.ToString("F2");
    }

    public float GetTime()
    {
        return timerElapsed;
    }

    public void StopTimer()
    {
        enabled = false;
    }
}
