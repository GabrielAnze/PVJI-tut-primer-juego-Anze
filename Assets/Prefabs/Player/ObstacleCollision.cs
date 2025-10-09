using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Est� colisionando");

        // Verificar si colision� con el Player
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("�Choc� con el Player! Destruyendo obst�culo...");
            Destroy(gameObject);
        }
    }
}