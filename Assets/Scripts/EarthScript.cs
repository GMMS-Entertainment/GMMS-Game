using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthScript : MonoBehaviour
{
    Vector3 touchPosWorld;
    Vector3 mousePosWorld;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

            RaycastHit2D touchHit = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

            if (touchHit.collider != null)
            {
                GameObject.Find("money").GetComponent<MoneyScript>().getMoney();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            mousePosWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePosWorld2D = new Vector2(mousePosWorld.x, mousePosWorld.y);

            RaycastHit2D mouseHit = Physics2D.Raycast(mousePosWorld2D, Camera.main.transform.forward);

            if (mouseHit.collider != null)
            {
                GameObject.Find("money").GetComponent<MoneyScript>().getMoney();
            }
        }
        transform.Rotate(0, 0, 2 * Time.deltaTime);
    }
}