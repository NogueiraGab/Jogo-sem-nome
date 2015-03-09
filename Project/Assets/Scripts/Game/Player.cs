using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed, jumpForce;

    void Start () 
    {
        renderer.receiveShadows = true;
        renderer.castShadows = true;
	}
	
	void Update ()
    {
        #region MOVIMENTAÇÃO BÁSICA
        if (Input.GetKey(KeyCode.D))
        {
            Movimentation.Move(this.gameObject, speed, DIRECTION.RIGHT);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Movimentation.Move(this.gameObject, speed, DIRECTION.LEFT);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Movimentation.Move(this.gameObject, speed, DIRECTION.UP);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Movimentation.Move(this.gameObject, speed, DIRECTION.DOWN);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Movimentation.Jump(this.gameObject, jumpForce);
        }
        #endregion
    }
}
