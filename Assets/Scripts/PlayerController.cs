using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BasicControls {
    public class AxisAtributtes : MonoBehaviour {
        protected const int UP = 1, RIGHT = 1;
        protected const int DOWN = -1, LEFT = -1;
        protected const int NO_MOVE = 0; 
    }

    public class PlayerController : MonoBehaviour {
        // Player Atributtes
        [SerializeField]
        private float moveSpeed;

        // Start is called before the first frame update
        void Start() { }

        // Update is called once per frame
        void Update() {
            float xAxis = Input.GetAxisRaw("Horizontal");
            if (xAxis > 0.5f || xAxis < -0.5f) {     // 0.5 but why?
                transform.Translate(new Vector3(xAxis * moveSpeed * Time.deltaTime, 0f, 0f));
            }

            float yAxis = Input.GetAxisRaw("Vertical");
            if (yAxis > 0.5f || yAxis < -0.5f) {     // 0.5 but why?
                transform.Translate(new Vector3(0f, yAxis * moveSpeed * Time.deltaTime, 0f));
            }
        }

        public void setMoveSpeed(float newMoveSpeed) {
            moveSpeed = newMoveSpeed;
        }

        public float getMoveSpeed() {
            return moveSpeed;
        }
    }
}