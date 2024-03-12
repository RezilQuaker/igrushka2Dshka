using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� �������� ����������
    public float followDistance = 10f; // ����������, �� ������� ��������� ������ ��������� �� �������
    public float stoppingDistance = 2f; // ����������, �� ������� ��������� ����������� ����� �������
    public float followSpeed = 7f; // �������� ���������� �� �������
    public Transform player; // ������ �� ������ ������

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ������������ ������ ����������� � ������
        Vector2 direction = player.position - transform.position;
        float distanceToPlayer = direction.magnitude;

        if (distanceToPlayer <= followDistance)
        {
            // ���� ����� ��������� � ���� ����������, ��������� �������� ��������� � ��� �������
            if (distanceToPlayer > stoppingDistance)
            {
                // �������� � ������
                Vector2 moveDirection = direction.normalized;
                rb.velocity = moveDirection * moveSpeed;
            }
            else
            {
                // ��������� ��������������� ����� �������
                rb.velocity = Vector2.zero;
            }
        }
        else
        {
            // ��������� �������� ��������� �������, ���� ����� ��������� �� ��������� ���� ����������
            rb.velocity = Random.insideUnitCircle.normalized * moveSpeed;
        }
    }
}