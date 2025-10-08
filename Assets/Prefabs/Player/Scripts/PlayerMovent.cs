using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IMovementStrategy movementStrategy;
    private Player player = new Player();

    public void SetMovementStrategy(IMovementStrategy newStrategy)
    {
        movementStrategy = newStrategy;
    }

    // NUEVO MÉTODO: Recibe el input como parámetro
    public void MovePlayer(float input)
    {
        movementStrategy.Move(transform, player, input);
    }
}