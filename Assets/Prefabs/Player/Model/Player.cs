using UnityEngine;

[System.Serializable]
public class Player
{
    [SerializeField] private float velocity = 5f;
    [SerializeField] private float acceleration = 10f;

    public float Velocity
    {
        get { return velocity; }
        set { velocity = value; }
    }

    public float Acceleration
    {
        get { return acceleration; }
    }
}