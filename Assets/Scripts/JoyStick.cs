using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour,IPointerUpHandler , IPointerDownHandler
{

    private PlayerJoyStick playerMove;
    void Start()
    {
        playerMove = GameObject.Find("Player").GetComponent<PlayerJoyStick>();

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (gameObject.name == "Left")
        {
            playerMove.setMoveLeft(true);
        }
        else { playerMove.setMoveLeft(false); }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (gameObject.name == "Left")
        {
            playerMove.stopMoving();
        }
        else { playerMove.stopMoving(); }
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
