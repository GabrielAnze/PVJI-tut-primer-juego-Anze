using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -10);
    private PlayerMovement player;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>();

        if (player == null)
        {
            Debug.LogError("No se encontró el PlayerMovement en la escena");
        }
    }

    private void LateUpdate()
    {
        if (player != null)
        {
            // Seguir al player manteniendo el offset
            transform.position = player.transform.position + offset;

            // Mirar siempre hacia el player
            transform.LookAt(player.transform);
        }
    }
}