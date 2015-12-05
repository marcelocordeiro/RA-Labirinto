using UnityEngine;
using System.Collections;

public class Colider : MonoBehaviour
{

    void OnCollisionEnter (Collision col)
    {
        Destroy(this.gameObject);
    }

}

