using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 8.0f;
    public float rotationSpeed = 1.0f;
    public GameObject projectile;
    public GameObject Pivot;
    public Transform firePoint;
    public float fireRate = 1.0f;

    private Rigidbody body;
    private Transform player;
    private float nextFireTime;

    public int maxHp = 3;
    public int currentHp = 3;

    // Start is called before the first frame update
    void Start()
    {
        maxHp = 3;
        currentHp = 3;

        body = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (Vector3.Distance(player.position, transform.position) > 5.0f)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                body.MovePosition(transform.position + direction * moveSpeed * Time.deltaTime);
            }

            Vector3 targetDirection = (player.position - Pivot.transform.position).normalized;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);

            Pivot.transform.rotation = Quaternion.Lerp(Pivot.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);



            if(Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1f / fireRate;
                GameObject temp = Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
                temp.GetComponent<ProjecttileMove>().projectileType = ProjecttileMove.PROFECTILETYPE.ENEMY;     //발사체에 적이 쏜 총알이라 이름붙임
            }
        }
    }
}
