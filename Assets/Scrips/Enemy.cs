using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    GameObject player;
    Rigidbody enemyRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = (player.transform.position - transform.position).normalized;
        enemyRigidbody.AddForce(moveDirection * speed * Time.deltaTime);
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
