Player player = new Player();
HealthDisplay healthDisplay = new HealthDisplay();

player.RegisterObserver(healthDisplay);

player.TakeDamage(10);
player.TakeDamage(20);
player.TakeDamage(30);
