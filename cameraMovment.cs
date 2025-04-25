using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed; // Vitesse de la caméra

    // La méthode Update est appelée une fois par frame
    void Update()
    {
        // Déplace la caméra horizontalement en fonction de la vitesse et du temps
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
    