namespace SmartCentral.Services.Spc.RawModel
{
    internal enum ZoneTypes : int
    {
        Alarm = 0,
        EntryExit = 1,
        ExitTerminator = 2,
        Fire = 3,
        FireExit = 4,
        Line = 5,
        Panic = 6,
        HoldUp = 7,
        Tamper = 8,
        Technical = 9,
        Medical = 10,
        Keyarm = 11,
        Unused = 12,
        Shunt = 13,
        XShunt = 14,
        Fault = 15,
        LockSupervision = 16,
        Seismic = 17,
        AllOkay = 18
    }
}
