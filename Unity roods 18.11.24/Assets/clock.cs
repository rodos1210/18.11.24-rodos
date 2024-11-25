using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class clock : MonoBehaviour
{
    public Transform hoursarmpivot;
    public Transform minutesarmpivot;
    public Transform secondspivot;
    private void Start()
    {
        hoursarmpivot.localRotation = Quaternion.Euler(0,0,-150);
    }
    private void Update()
    {
        DateTime t = DateTime.Now;
        hoursarmpivot.localRotation = Quaternion.Euler(0, 0,-30 * t.Hour - (0.5f * t.Minute));
        minutesarmpivot.localRotation = Quaternion.Euler(0, 0, -6 * t.Minute - (0.1f *t.Second));
        secondspivot.localRotation = Quaternion.Euler(0,0, -6 * t.Second -  (0.006f * t.Millisecond));
    }
}
