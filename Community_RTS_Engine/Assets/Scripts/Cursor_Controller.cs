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
                if (camGameObject.transform.position.x <= 0)
                    camGameObject.transform.position = new Vector3(0, camGameObject.transform.position.y, camGameObject.transform.position.z);
            }

            if (mousePosX >= Screen.width - scrollDistance)
            {
                camGameObject.transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);
                if (camGameObject.transform.position.x >= 78)
                    camGameObject.transform.position = new Vector3(78, camGameObject.transform.position.y, camGameObject.transform.position.z);
            }

            if (mousePosY < scrollDistance)
            {
                camGameObject.transform.Translate(Vector3.up * -scrollSpeed * Time.deltaTime);

                if (camGameObject.transform.position.y <= 0)
                    camGameObject.transform.position = new Vector3(camGameObject.transform.position.x, 0, camGameObject.transform.position.z);
            }

            if (mousePosY >= Screen.height - scrollDistance)
            {
                camGameObject.transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
                if (camGameObject.transform.position.y >= 89)
                    camGameObject.transform.position = new Vector3(camGameObject.transform.position.x, 89, camGameObject.transform.position.z);
            }
            cam.orthographicSize = Screen.height / 16f / 2f;
        }

    }
}
