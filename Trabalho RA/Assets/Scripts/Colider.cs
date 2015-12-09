using UnityEngine;
using UnityEditor;
using System.Collections;

public class Colider : MonoBehaviour
{
    int pontos = 100;

    Color old = RenderSettings.ambientLight;

    public GameObject esfera;
    public GameObject finish;

    void OnCollisionEnter (Collision col)
    {
        Color cor = Color.red;
        if (col.gameObject == finish)
        {
            cor = Color.green;
            old = Color.green;
        }
        RenderSettings.ambientLight = cor;
    }

    void OnCollisionExit (Collision col)
    {
        RenderSettings.ambientLight = old;
        if (old == Color.green)
        {
            EditorUtility.DisplayDialog("Fim de jogo", "Sua pontuação final é " + pontos, "Ok");
            pontos = 100;
        }
        else
            pontos--;
    }

    void Update()
    {
        //esfera.transform.position = new Vector3(this.transform.position.x, plano.transform.position.y, this.transform.position.z);
    }
}

