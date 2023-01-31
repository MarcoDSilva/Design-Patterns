using Behavioral.Command.Services.Commands;
using Behavioral.Command.Services.Interfaces;
using Behavioral.Command.Services.Models;

Light light = new Light();

ICommand onCommand = new TurnOnLightCommand(light);
ICommand offCommand = new TurnOffLightCommand(light);

RemoteControl remoteControl = new RemoteControl(onCommand, offCommand);

remoteControl.TurnOn();
remoteControl.TurnOff();