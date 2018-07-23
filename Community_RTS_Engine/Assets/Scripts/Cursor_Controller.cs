using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Cursor_Controller : MonoBehaviour
    {
        public GameObject camGameObject;
        public Vector3 mouseStart, mouseCurr;
        Camera cam;
        // Use this for initialization
        void Start()
        {
            mouseStart = mouseCurr = Vector3.zero;
            cam = camGameObject.GetComponent<Camera>();
        }

        // Update is called once per frame
        void Update()
        {
            float mousePosX = Input.mousePosition.x;
            float mousePosY = Input.mousePosition.y;
            int scrollDistance = 5;
            float scrollSpeed = 40;
            if (mousePosX < scrollDistance)
            {
                camGameObject.transform.Translate(Vector3.right * -scrollSpeed * Time.deltaTime);
            }

            if (mousePosX >= Screen.width - scrollDistance)
            {
                camGameObject.transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);
            }

            if (mousePosY < scrollDistance)
            {
                camGameObject.transform.Translate(Vector3.up * -scrollSpeed * Time.deltaTime);
            }

            if (mousePosY >= Screen.height - scrollDistance)
            {
                camGameObject.transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
            }
            cam.orthographicSize = Screen.height / 16f / 2f;
        }

    }
}
