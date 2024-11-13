using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using TMPro;


public class ColorPicker : MonoBehaviour
{
    [DllImport("ColorPickerDLL")]
    private static extern System.IntPtr GetColor(int index);
    public delegate void ColorChangedDelegate();
    public static ColorChangedDelegate OnColorChanged;

    public TextMeshProUGUI colorText; 

    public static int currentColorIndex = 0;
    private int numberOfColors = 5; 

    void Start()
    {
        ChangeColor();     }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            ChangeColor();
            OnColorChanged?.Invoke();
        }
    }

    public void ChangeColor()
    {
        string colorName = GetColorFromDLL(currentColorIndex);
        colorText.color = GetUnityColor(colorName);
        //colorText.text = "This text is now " + colorName;
        
        currentColorIndex = (currentColorIndex + 1) % numberOfColors; 
    }

    public static string GetColorFromDLL(int index)
    {
        return Marshal.PtrToStringAnsi(GetColor(index));
    }

    public static Color GetUnityColor(string colorName)
    {
        switch (colorName)
        {
            case "Red":
                return Color.red;
            case "Green":
                return Color.green;
            case "Blue":
                return Color.blue;
            case "Yellow":
                return Color.yellow;
            case "Purple":
                return new Color(0.5f, 0f, 0.5f); // Custom color for purple
            default:
                return Color.black; 
        }
    }
}