using UnityEngine;

public class AcelerateMovement : IMovementStrategy
{
    private float currentSpeed = 0f;
    private float maxSpeed = 8f;

    public void Move(Transform transform, Player player, float input)
    {
        currentSpeed += input * player.Acceleration * Time.deltaTime;
        currentSpeed = Mathf.Clamp(currentSpeed, -maxSpeed, maxSpeed);
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);

        if (Mathf.Abs(input) < 0.1f)
        {
            currentSpeed = Mathf.Lerp(currentSpeed, 0, Time.deltaTime * 2f);
        }
    }
}