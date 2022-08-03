namespace MockMiniASP_Net_Core
{
    public interface IServer
    {
        Task StartAsync(RequestDelegate handler);
    }
}
