using System;
using System.Threading;
using System.Collections.Generic;

class BreathingActivity: Activity
{

    public BreathingActivity(string activityName, string description, int duration, string endingMessage ) :base(activityName, description, duration, endingMessage)
    {
        this._activityName = "";

    }
}
