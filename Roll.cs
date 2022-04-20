using UnityEngine;
using UnityEngine.UI;

public class Roll : MonoBehaviour
{
    bool isRollStart;
    float speedOfRoll;
    float speedReduction;
    float curentSpeed;

    [SerializeField] Button rollClass;

    public static bool isRollEnd;

    void Start()
    {
        
        MakeParametersRandom();
    }
    
    void FixedUpdate()
    {
        SpeedRoll();
        Rolled();
        StopRolled();
    }

    void MakeParametersRandom()
    {
        speedOfRoll = Random.Range(422f, 1099f);
        speedReduction = Random.Range(0.7f, 9f);
    }

    void SpeedRoll()
    {
        if (isRollStart)
        {
            curentSpeed = speedOfRoll -= speedReduction;
            rollClass.interactable = false;
        }
    }

    public void StartRoll() => isRollStart = true;

    void Rolled()
    {
        if (isRollStart)
            transform.Rotate(0, 0, curentSpeed * Time.deltaTime, Space.Self);
    }

    void StopRolled()
    {
        if (curentSpeed <= 0 && isRollStart)
        {
            curentSpeed = 0;
            isRollEnd = true;
            isRollStart = false;

        }
    }
}
