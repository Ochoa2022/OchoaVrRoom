using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookOpen : MonoBehaviour
{
    public GameObject Cover;
    public HingeJoint hinge;
    // Start is called before the first frame update
    void Start()
    {
        var hinge = Cover.GetComponent<HingeJoint>();
        hinge.useMotor = false;
    }

    // Update is called once per frame
    public void OpenSesame()
    {
        hinge.useMotor = true;

    }
}
