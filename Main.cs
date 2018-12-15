using GTANetworkAPI;

namespace Example
{
    public class Main : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            NAPI.Util.ConsoleOutput("Main class loaded!");
        }
    }
}