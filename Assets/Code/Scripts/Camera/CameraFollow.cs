using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objetivo;     // Jugador o cualquier objeto a seguir
    public float suavizado = 0.125f; // Qué tan suave se mueve la cámara (opcional)
    public Vector3 offset;         // Desfase opcional de la cámara

    public Vector3 camaraLimiteIzquierdo = new Vector3 (3.4f,0,0);
    public Vector3 camaraLimiteDerecho = new Vector3(53.4f, 0, 0);

    public bool isLimited;


    void LateUpdate()
    {
        if (objetivo == null)
        {
            return;
        }
        else if (!isLimited)
        {
            // Solo seguimos en el eje X, mantenemos Y y Z actuales
            Vector3 posicionActual = transform.position;
            Vector3 posicionDeseada = new Vector3(objetivo.position.x + offset.x, posicionActual.y, posicionActual.z + offset.z);

            // Suavizado (opcional)
            transform.position = Vector3.Lerp(posicionActual, posicionDeseada, suavizado);
        }
    }

    private void Start()
    {
        transform.position = new Vector3(objetivo.position.x, objetivo.position.y, -10f);
    }

    private void Update()
    {
        LimitesCamara();
    }
    private void LimitesCamara()
    {
        if (transform.position.x >= 3.4f && transform.position.x <= 53.4f)
        {
            isLimited = true;
        }
        else
        {
            isLimited = false;
        }
    }
}
