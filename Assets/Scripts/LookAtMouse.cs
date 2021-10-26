using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);  
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        // Нахождение катетов для расчёта тангенса, а в последствии и градусов угла.
        // Нахождение тангенса угла и перевод его в градусы.
        // Вращение объекта на полученное значение градусов.
    }

}
