Originator originator = new Originator();
CareTaker careTaker = new CareTaker();

originator.SetState("State1");
originator.SetState("State2");
careTaker.Add(originator.SaveStateToMemento());

originator.SetState("State3");
careTaker.Add(originator.SaveStateToMemento());

originator.SetState("State4");
Console.WriteLine("Current State: " + originator.GetState());

originator.RestoreStateFromMemento(careTaker.Get(1));