using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpVelocityEntrer : MonoBehaviour
{
    public Rigidbody PersoRb;
    public Transform PositionRb;
    public static bool contact;
    public static bool Sortie;
    public string Direction;

    [SerializeField]
    private Vector3 PersoVelocity;
    private Transform Portail2;

    // Start is called before the first frame update
    void Start()
    {
        contact = false;
        Sortie = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Sortie)
        {
            Debug.Log("B1");
            if (other.CompareTag("Player"))
            {
                Debug.Log("B2");
                Portail2 = GameObject.Find("PortailSortie(Clone)").transform;
                Debug.Log(Portail2.position);
                PositionRb.position = new Vector3(Portail2.position.x, Portail2.position.y, Portail2.position.z);
                Debug.Log(PersoRb.position);
                contact = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        PersoVelocity = PersoRb.velocity;
        if (contact)
        {
            if (Direction == "Est")
            {
                if (PersoVelocity.x >= 0)
                {
                    PersoRb.velocity = new Vector3(PersoVelocity.x * -1, PersoVelocity.y, PersoVelocity.z);
                }
            }
            else if (Direction == "Ouest")
            {
                if (PersoVelocity.x <= 0)
                {
                    PersoRb.velocity = new Vector3(PersoVelocity.x * -1, PersoVelocity.y, PersoVelocity.z);
                }
            }
            else if (Direction == "Nord")
            {
                if (PersoVelocity.y >= 0)
                {
                    PersoRb.velocity = new Vector3(PersoVelocity.x, PersoVelocity.y * -1, PersoVelocity.z);
                }
            }
            else if (Direction == "Sud")
            {
                if (PersoVelocity.y <= 0)
                {
                    PersoRb.velocity = new Vector3(PersoVelocity.x, PersoVelocity.y * -1, PersoVelocity.z);
                }
            }
            contact = false;
        }
    }
}
