using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour {

    public Material defaultMaterial;
    private Color white = Color.white;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10)//player
        {
            collision.transform.Find("Indicator").gameObject.GetComponent<Renderer>().material = defaultMaterial;
            collision.transform.Find("Indicator").gameObject.GetComponent<Renderer>().materials[1].SetColor("_OutlineColor", white);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
