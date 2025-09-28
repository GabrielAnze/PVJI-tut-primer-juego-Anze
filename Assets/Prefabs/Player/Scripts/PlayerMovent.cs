using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private IMovementStrategy movementStrategy;

    private void Start()
    {
        // Inicializamos con la estrategia suave
        SetMovementStrategy(new SmoothMovement());
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
        movementStrategy.Move(transform, speed);
    }
}