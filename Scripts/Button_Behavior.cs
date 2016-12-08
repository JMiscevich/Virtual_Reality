using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_Behavior : MonoBehaviour {

    Button button;
    public Color newColor;

    void OnEnable()
    {
        button = gameObject.GetComponent<Button>();
    }

    // Use this for initialization
    void Start () {
        
	}

    private void OnMouseEnter()
    {
        changeColorGreen();
    }

    private void OnMouseExit()
    {
        changeColorWhite();
    }

    public void changeColorGreen() {
        ColorBlock cb = button.colors;
        cb.normalColor = newColor;
        button.colors = cb;
    }

    public void changeColorWhite()
    {
        ColorBlock cb = button.colors;
        cb.normalColor = new Color(255,255,255);
        button.colors = cb;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
