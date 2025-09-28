using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IMovementStrategy movementStrategy;
    private Player player = new Player();

    private void Start()
    {
        // Prueba cambiando entre estas estrategias:
        SetMovementStrategy(new SmoothMovement());// Movimiento suave
        // SetMovementStrategy(new AcelerateMovement()); // Movimiento acelerado
    }

    private void Update()
    {
        MovePlayer();
    }

    public void SetMovementStrategy(IMovementStrategy newStrategy)
    {
        movementStrategy = newStrategy;
    }

    private void MovePlayer()
    {
        movementStrategy.Move(transform, player);
    }
}