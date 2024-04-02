using prototype_design_pattern.Entities;

var AgentSmith = new ArtificialIntelligence ("Agente Smith");
var AgentSmithClone = AgentSmith.Clone();
AgentSmithClone.ResetName("Agente Smith Clonado");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Prototype Design Pattern");
Console.WriteLine("------------------------");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(AgentSmith.ToString());
Console.WriteLine(AgentSmithClone.ToString());
