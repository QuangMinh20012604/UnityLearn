using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private List<Transform> targets;
    private int step = 0;
    void Update()
    {
        //Vector2 a;
        //Vector2 b;

        //Xe tu dong chay
        if (step < targets.Count)
        {
            transform.Translate((targets[step].position - transform.position).normalized * speed * Time.deltaTime);
            if ((transform.position - targets[step].position).magnitude < 0.1f)
            {
                step++;
            }
        }

        //xe tu dong chay xong co the dung nut dieu huong de dieu khien nhung khi xe dang chay tu dong van co the dieu huong duoc
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))    //getkey di chuyển khi nhấn giữ nút còn getbutton nhấn nhả để di chuyển
        {
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
    }
}