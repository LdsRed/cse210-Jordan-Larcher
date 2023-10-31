using System;
using System.Threading;
using System.Collections.Generic;

class BreathingActivity: Activity
{
    private List<string> _prompt;
    private List<string> _reflexion;

    public BreathingActivity(string activityName, string description, int duration, string endingMessage ) :base(activityName, description, duration, endingMessage)
    {
        

    }
}
