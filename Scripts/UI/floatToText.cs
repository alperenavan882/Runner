using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class floatToText : MonoBehaviour
{

    public PlayerHealth script;
    public TextMeshProUGUI scoreText;

    private float HealthValue;

    private void Awake()
    {
        HealthValue = script.Health;
    }

    private void Update()
    {
        HealthValue = script.Health;
        scoreText.text = HealthValue.ToString("0");
    }




}
