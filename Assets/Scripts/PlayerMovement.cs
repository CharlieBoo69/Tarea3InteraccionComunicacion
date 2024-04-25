using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.C))
        {
            TargetColorChange targetColorChange = FindObjectOfType<TargetColorChange>();
            if (targetColorChange != null)
            {
                Color newColor = Random.ColorHSV(); 
                targetColorChange.ChangeColor(newColor);
            }
        }
    }
}
