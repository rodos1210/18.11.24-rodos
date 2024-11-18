using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class clock : MonoBehaviour
{
    public Transform hoursarmpivot;
    public Transform minutesarmpivot;
    private void Start()
    {
        hoursarmpivot.localRotation = Quaternion.Euler(0,0,-150);
    }
    private void Update()
    {
        DateTime t = DateTime.Now;
        hoursarmpivot.localRotation = Quaternion.Euler(0, 0,-30 * t.Hour);
        minutesarmpivot.localRotation = Quaternion.Euler(0, 0, -6 * t.Minute);
    }
}
