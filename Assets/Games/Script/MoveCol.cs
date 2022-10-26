using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Games.Script
{
    public class MoveCol : MonoBehaviour
    {
        public int speed = 1;

        void Update()
        {
            if (Math.Abs(transform.position.x - (-13)) < 0.5)
            {
                transform.position = new Vector3(15, Random.Range(-1, 3.5f), 0);
            }
            else
            {
                transform.Translate(Vector3.left * (Time.deltaTime * speed / 2));
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("wall:" + other.gameObject.name);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            GameController.ins.PlusScore();
        }
    }
}