using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        // Detectar input horizontal
        float horizontalInput = Input.GetAxis("Horizontal");

        // Si hay input, ejecutar comando
        if (Mathf.Abs(horizontalInput) > 0.1f)
        {
            // Si se presiona Space, usar movimiento acelerado
            if (Input.GetKey(KeyCode.Space))
            {
                ICommand command = new AccelerateMoveCommand(playerMovement, horizontalInput);
                command.Execute();
            }
            else
            {
                // Movimiento normal suave
                ICommand command = new MoveCommand(playerMovement, horizontalInput);
                command.Execute();
            }
        }
    }
}