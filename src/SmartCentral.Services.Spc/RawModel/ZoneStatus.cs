namespace SmartCentral.Services.Spc.RawModel
{
    internal enum ZoneStatus : int
    {
        OK = 0,
        Inhibit = 1,
        Isolate = 2,
        Soak = 3,
        Tamper = 4,
        Alarm = 5,
        OkButNotUsedRecently = 6,
        Trouble = 7
    }
}
