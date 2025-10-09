using UnityEngine;

public class ForwardMoveCommand : ICommand
{
    private readonly PlayerMovement playerMovement;

    public ForwardMoveCommand(PlayerMovement playerMovement)
    {
        this.playerMovement = playerMovement;
    }

    public void Execute()
    {
        // Movimiento hacia adelante simple
        playerMovement.transform.Translate(Vector3.forward * 4f * Time.deltaTime);
    }
}