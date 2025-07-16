using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Variable de Texto

    [SerializeField] private TMP_Text _greetingText;


    // Variable de InputField

    [SerializeField] private TMP_InputField _inputField;


    // Variable de Botón

    [SerializeField] private Button _button;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // El texto dice: "Hola, ¿Cómo te llamas?"

        _greetingText.text = "Hola, ¿Cómo te llamas?";
        _button.onClick.AddListener(Greet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Greet()
    {
        // Guardar el nombre del usuario
        string name = _inputField.text;

        // Actualizar el texto del saludo
        _greetingText.text = "Hola, " + name + ", comencemos";

        _inputField.gameObject.SetActive(false);
        _button.gameObject.SetActive(false);

    }

}
