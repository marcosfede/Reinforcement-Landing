using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NNLandingAcademy : Academy {

    public float thrustSpeed;
    public float xRandRange;
    public float xPlatformSpeed;
    public float xPlatformRandRange;

    public override void AcademyReset()
    {
        thrustSpeed = (float)resetParameters["thrust_speed"];
        xRandRange = (float)resetParameters["x_rand_range"];
        xPlatformSpeed = (float)resetParameters["platform_speed"];
        xPlatformRandRange = (float)resetParameters["x_platform_rand_range"];
    }

    public override void AcademyStep()
    {


    }

}
