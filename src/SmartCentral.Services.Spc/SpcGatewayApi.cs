using System.Text.Json;
using SmartCentral.Services.Spc.RawModel;

namespace SmartCentral.Services.Spc;

internal class SpcGatewayApi
{
    //private const string IPGATEWAY = "192.168.0.253";
    //private const int PORTGATEWAY = 8088;
    private const string GETALLZONES = "/spc/zone";
    private const string GETALLAREAS = "/spc/area";
    private const string GETPANELSTATUS = "/spc/panel";
    private readonly string Ip;
    private readonly int Port;
    private readonly HttpClient ApiClient;

    public SpcGatewayApi(string ip, int port, HttpClient apiClient)
    {
        Ip = ip;
        Port = port;
        ApiClient = apiClient;
    }

    internal async Task<Zones?> GetAllZonesAsync(CancellationToken cancellationToken)
    {
        var json = await MakeApiCallAsync($"http://{Ip}:{Port}{GETALLZONES}", cancellationToken);
        if (string.IsNullOrEmpty(json))
            return null;

        return JsonSerializer.Deserialize<Zones>(json);
    }

    internal async Task<Areas?> GetAllAreasAsync(CancellationToken cancellationToken)
    {
        var json = await MakeApiCallAsync($"http://{Ip}:{Port}{GETALLAREAS}", cancellationToken);
        if (string.IsNullOrEmpty(json))
            return null;

        return JsonSerializer.Deserialize<Areas>(json);
    }

    internal async Task<PanelStatus?> GetPanelStatusAsync(CancellationToken cancellationToken)
    {
        var json = await MakeApiCallAsync($"http://{Ip}:{Port}{GETPANELSTATUS}", cancellationToken);
        if (string.IsNullOrEmpty(json))
            return null;

        return JsonSerializer.Deserialize<PanelStatus>(json);
    }

    internal async Task<string?> MakeApiCallAsync(string apiString, CancellationToken cancellationToken)
    {
        try
        {
            return await ApiClient.GetStringAsync(apiString, cancellationToken);
        }
        catch (Exception)
        {
            return null;
        }        
    }
}