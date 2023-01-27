using Structural.Composite.Services;

var composite = new Composite() { Name = "root" };

composite.Add(new Leaf() { Name = "leaf 1" });
composite.Add(new Leaf() { Name = "leaf 2" });

var secondComposite = new Composite() { Name = "root2"};

secondComposite.Add(new Leaf() { Name = "leaf 3" });
secondComposite.Add(new Leaf() { Name = "leaf 4" });

composite.Add(secondComposite);

composite.Display(0);
