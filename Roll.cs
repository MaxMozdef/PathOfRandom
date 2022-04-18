using UnityEngine;

public class Roll : MonoBehaviour
{
    bool isRollStart;
    float speedOfRoll;
    float speedReduction;
    float curentSpeed;

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
        speedOfRoll = Random.Range(222, 899);
        speedReduction = Random.Range(0.7f, 5);
    }

    void SpeedRoll()
    {
        if (isRollStart)
            curentSpeed = speedOfRoll -= speedReduction;
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
