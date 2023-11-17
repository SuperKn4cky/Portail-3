using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpVelocitySortie : MonoBehaviour
{
    public Rigidbody PersoRb;
    public static bool contact;
    public static bool Entrer;
    public string Direction;

    [SerializeField]
    private Vector3 PersoVelocity;
    private Transform Personnage;
    private Transform Portail2;

    // Start is called before the first frame update
    void Start()
    {
        Personnage = PersoRb.GetComponent<Transform>();
        contact = false;
        Entrer = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Entrer)
        {
            Debug.Log("B1");
            if (other.CompareTag("Player"))
            {
                Debug.Log("B2");
                Portail2 = GameObject.Find("PortailEntrer(Clone)").transform;
                Debug.Log("is portail");
                Personnage.position = new Vector3(Portail2.position.x, Portail2.position.y, Portail2.position.z);
                Debug.Log("P2" + PersoRb.transform.position);
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