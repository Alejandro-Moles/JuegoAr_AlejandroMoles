using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    private TextMeshProUGUI TextPoints;
    private float NumPoints;

    private void Start()
    {
        TextPoints = FindObjectOfType<TextMeshProUGUI>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Destroy(collision.transform.gameObject);
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            SumPoints(1);
        }
        else if(collision.transform.tag == "Ally")
        {
                Destroy(collision.transform.gameObject);
                Instantiate(explosion, collision.transform.position, collision.transform.rotation);
                RestPoints(1);
        }
    }

    public void SumPoints(int points)
    {
       
        NumPoints = float.Parse(TextPoints.text);
        NumPoints += points;
        TextPoints.text = NumPoints.ToString();
    }

    public void RestPoints(int points)
    {
        NumPoints = float.Parse(TextPoints.text);
        NumPoints -= points;
        TextPoints.text = NumPoints.ToString();
    }

}
