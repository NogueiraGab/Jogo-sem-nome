using UnityEngine;
using System.Collections;

public enum DIRECTION
{
    UP,
    DOWN,
    LEFT,
    RIGHT
}
public class Movimentation : MonoBehaviour 
{

    public static void Move(GameObject g, float speed = 0.05f, DIRECTION d = DIRECTION.DOWN)
    {
        switch (d)
        {
            case DIRECTION.DOWN:  g.transform.position += new Vector3 (0, 0, -speed);  break;

            case DIRECTION.UP:    g.transform.position += new Vector3 (0, 0, speed);   break;

            case DIRECTION.LEFT:  g.transform.position += new Vector3 (-speed, 0, 0);  break;

            case DIRECTION.RIGHT: g.transform.position += new Vector3 (speed, 0, 0);   break;
        }
    }

    public static void Jump(GameObject g, float force)
    {
        g.gameObject.rigidbody.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
    }
}
