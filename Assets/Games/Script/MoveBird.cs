using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Games.Script
{
    public class MoveBird : MonoBehaviour
    {
        public int speed = 1;

        [SerializeField] private Rigidbody2D _rigi;

        void Update()
        {
            if (Input.GetMouseButtonDown(0) && GameController.ins.isStart)
            {
                _rigi.velocity = Vector3.zero;
                _rigi.AddForce(new Vector2(0, speed));
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("AAAAAAAAA!");
            GameController.ins.GameOver();
        }
    }
}