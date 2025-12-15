using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //public Material firstColorMaterial;   
    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Golden1"))
        //{
        //    Renderer r = other.GetComponent<Renderer>();
        //    if (r != null)
        //    {
        //        r.material = firstColorMaterial;
        //    }
        //}

        //if (other.CompareTag("Golden2"))
        //{
        //    Renderer r = other.GetComponent<Renderer>();
        //    if (r != null)
        //    {
        //        //r.enabled = false;   
        //         other.gameObject.SetActive(false);
        //    }

            if (other.CompareTag("Obstacle"))
            {
                Destroy(other.gameObject);  // Destroy the player
            }

        }
    }

