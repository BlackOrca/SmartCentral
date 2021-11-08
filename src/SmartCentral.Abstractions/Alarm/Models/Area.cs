namespace SmartCentral.Abstractions.Alarm.Models;

public record Area(Guid Id, string Name, SetStatus SetStatus, Status AlarmStatus);