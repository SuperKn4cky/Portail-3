using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCanon : MonoBehaviour
{
    public Transform Joueur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Joueur.position.x - 1, Joueur.position.y + 1, 0);
    }
}
