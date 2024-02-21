var machine = new MicrowavedFoodMachine();
var food = machine.MakeFood(MicrowavedFoodMachine.AvailableFood.Pizza, 10);
var otherFood = machine.MakeFood(MicrowavedFoodMachine.AvailableFood.ChowMein, 20);

food.Consume();
otherFood.Consume();