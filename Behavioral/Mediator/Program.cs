ChatRoom mediator = new ChatRoom();

User user1 = new ConcreteUser1(mediator, "User1");
User user2 = new ConcreteUser2(mediator, "User2");

mediator.SendMessage(user1, "Hi All");
mediator.SendMessage(user2, "Hello");