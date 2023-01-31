using Behavioral.Command.Services.Interfaces;
using Behavioral.Command.Services.Models;

namespace Behavioral.Command.Services.Commands;

public class TurnOffLightCommand : ICommand
{
    private Light _light;
    public TurnOffLightCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.TurnOff();    
}