using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move() 
    {

        //Horizontal
        var deltaX = Input.GetAxis("Horizontal");
        var newposX = transform.position.x + (deltaX * 0.05f);

        //Vertical
        var deltaY = Input.GetAxis("Vertical");
        var newposY = transform.position.y + (deltaY * 0.05f);

        this.transform.position = new Vector2(newposX, newposY);
    }
}
