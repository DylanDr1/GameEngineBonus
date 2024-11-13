using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [DllImport("ColorPickerDLL")]
    private static extern System.IntPtr GetColor(int index);
    
    public float jumpPower;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ColorPicker.OnColorChanged += Changecolor;
    }

    void Changecolor()
    {
        
        string colorName = ColorPicker.GetColorFromDLL(ColorPicker.currentColorIndex);
        spriteRenderer.color = ColorPicker.GetUnityColor(colorName);
    }
}
