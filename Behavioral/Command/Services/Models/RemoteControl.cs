using Behavioral.Command.Services.Interfaces;

namespace Behavioral.Command.Services.Models;

public class RemoteControl
{
    private ICommand _onCommand;
    private ICommand _offCommand;

    public RemoteControl(ICommand onCommand, ICommand offComand)
    {
        _onCommand = onCommand;
        _offCommand = offComand;
    }

    public void TurnOn() => _onCommand.Execute();
    public void TurnOff() => _offCommand.Execute();
}