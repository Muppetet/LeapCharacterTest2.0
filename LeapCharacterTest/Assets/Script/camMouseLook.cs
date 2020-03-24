using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMouseLook : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivty = 5.0f;
    public float smoothing = 2.0f;

    GameObject character;
    void Start()
    {
        character = this.transform.parent.gameObject;
    }
    void Update()
    {
        Vector2 mAxis = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        mAxis = Vector2.Scale(mAxis, new Vector2(sensitivty * smoothing, sensitivty * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, mAxis.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, mAxis.y, 1f / smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);


        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 5f, Color.red);

    }
}
