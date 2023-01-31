using Behavioral.CoR.Services.Abstractions;
using Behavioral.CoR.Services.Models;

Handler handlerA = new ConcreteHandlerA();
Handler handlerB = new ConcreteHandlerB();
Handler handlerC = new ConcreteHandlerC();

handlerA.SetSucessor(handlerB);
handlerB.SetSucessor(handlerC);

int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

foreach (int request in requests)
{
    handlerA.HandleRequest(request);
}