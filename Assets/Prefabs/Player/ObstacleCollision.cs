using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Está colisionando");

        // Verificar si colisionó con el Player
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("¡Chocó con el Player! Destruyendo obstáculo...");
            Destroy(gameObject);
        }
    }
}