namespace SmartCentral.Services.Spc.RawModel
{
    internal enum ZoneInputs : int
    {
        Closed = 0,
        Open = 1,
        Short = 2,
        Disconnected = 3,
        PirMasked = 4,
        DcSubstitution = 5,
        SensorMissing = 6,
        Offline = 7
    }
}
