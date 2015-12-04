using UnityEngine;
using System.Collections;

public class Troca : MonoBehaviour {

    public GameObject carro, aviao, jet, pessoa;
    bool bcarro, baviao, bjet, bpessoa;

    void Start () {
        bcarro = false;
        baviao = false;
        bjet = false;
        bpessoa = false;
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            bcarro = true;
            baviao = false;
            bjet = false;
            bpessoa = false;
        }
        if (bcarro)
        {
            carro.SetActive(true);
            aviao.SetActive(false);
            jet.SetActive(false);
            pessoa.SetActive(false);
        }



        if (Input.GetKeyDown(KeyCode.P))
        {
            bcarro = false;
            baviao = false;
            bjet = false;
            bpessoa = true;
        }
        if (bpessoa)
        {
            carro.SetActive(false);
            aviao.SetActive(false);
            jet.SetActive(false);
            pessoa.SetActive(true);
        }



        if (Input.GetKeyDown(KeyCode.A))
        {
            bcarro = false;
            baviao = true;
            bjet = false;
            bpessoa = false;
        }
        if (baviao)
        {
            carro.SetActive(false);
            aviao.SetActive(true);
            jet.SetActive(false);
            pessoa.SetActive(false);
        }



        if (Input.GetKeyDown(KeyCode.J))
        {
            bcarro = false;
            baviao = false;
            bjet = true;
            bpessoa = false;
        }
        if (bjet)
        {
            carro.SetActive(false);
            aviao.SetActive(false);
            jet.SetActive(true);
            pessoa.SetActive(false);
        }



        if (!(bcarro || baviao || bpessoa || bjet))
        {
            carro.SetActive(false);
            aviao.SetActive(false);
            jet.SetActive(false);
            pessoa.SetActive(false);
        }

        ARController hi;
        
    }
}
