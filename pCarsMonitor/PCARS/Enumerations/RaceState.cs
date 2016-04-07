using System.ComponentModel;

namespace pCarsTelemetry.Enumerations
{
    public enum RaceState
    {
        [Description("Invalid")]
        RACESTATE_INVALID = 0,
        [Description("Not started")]
        RACESTATE_NOT_STARTED,
        [Description("Racing")]
        RACESTATE_RACING,
        [Description("Finished")]
        RACESTATE_FINISHED,
        [Description("Disqualified")]
        RACESTATE_DISQUALIFIED,
        [Description("Retired")]
        RACESTATE_RETIRED,
        [Description("DNF")]
        RACESTATE_DNF,
        //-------------
        RACESTATE_MAX
    }
}
