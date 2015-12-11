using UnityEngine;
using System.Collections;

public class Colider : MonoBehaviour
{
    int pontos;

    Color old;

    public GameObject esfera;
    public GameObject finish;


    private Rect windowRect = new Rect((Screen.width - 200) / 2, (Screen.height - 100) / 2, 200, 80);
    private bool show = false;

    void Start ()
    {
        old = RenderSettings.ambientLight;
        pontos = 100;
    }

    void Update ()
    {
        if (old == Color.green)
        {
            Open();
        }
    }

    void OnCollisionEnter (Collision col)
    {
        Color cor = Color.red;
        if (col.gameObject == finish)
        {
            RenderSettings.ambientLight = Color.green;
            cor = Color.green;
            old = Color.green;
        }
        RenderSettings.ambientLight = cor;
    }

    void OnCollisionExit (Collision col)
    {
        RenderSettings.ambientLight = old;
        if (old != Color.green)
            pontos--;
    }

    void OnGUI()
    {
        if (show)
            windowRect = GUI.Window(0, windowRect, DialogWindow, "Parabéns!");
    }

    void DialogWindow(int windowID)
    {
        float y = 20;
        GUI.Label(new Rect(5, y, windowRect.width, 20), "Sua pontuação final é " + pontos);

        if (GUI.Button(new Rect(5, y + 35, windowRect.width - 10, 20), "Ok"))
        {
            Application.Quit();
            show = false;
        }
    }

    void Open()
    {
        show = true;
    }
}

