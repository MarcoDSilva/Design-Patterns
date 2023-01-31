using Behavioral.Command.Services.Interfaces;
using Behavioral.Command.Services.Models;

namespace Behavioral.Command.Services.Commands;

public class TurnOnLightCommand : ICommand
{
    private Light _light;
    public TurnOnLightCommand(Light light)
    {
        _light = light;
    }

    public void Execute() => _light.TurnOn();    
}