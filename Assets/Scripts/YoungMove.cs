using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoungMove : MonoBehaviour
{
   public float speed = 5f; // 移动速度
    public Vector3 pointA; // 移动的起点
    public Vector3 pointB; // 移动的终点
    private Rigidbody rb;
    private bool movingToB = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = pointA;
        UpdateDirection();
    }

    void FixedUpdate()
    {
        Vector3 targetPoint = movingToB ? pointB : pointA;
        Vector3 direction = (targetPoint - transform.position).normalized;

        // 设置刚体速度而不是施加力
        rb.velocity = direction * speed;

        if (Vector3.Distance(transform.position, targetPoint) < 0.1f)
        {
            movingToB = !movingToB;
            UpdateDirection();
            rb.velocity = Vector3.zero; // 停止物体的运动
        }
    }

    void UpdateDirection()
    {
        Vector3 targetPoint = movingToB ? pointB : pointA;
        Vector3 direction = (targetPoint - transform.position).normalized;

        // 将模型方向调整为指向目标点
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}
