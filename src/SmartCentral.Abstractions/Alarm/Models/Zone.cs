namespace SmartCentral.Abstractions.Alarm.Models;

public record Zone(Guid Id, string Name, Status ZoneStatus, Detector Detector);

