using refactoring_knowledge_share;

Console.WriteLine($"=== Process Problems start ===");
var processProblems = new ProcessProblems();
processProblems.Process();
Console.WriteLine($"=== Process Problems end ===");

Console.WriteLine();

Console.WriteLine($"=== Process Solutions start ===");
var processSolutions = new ProcessSolutions();
processSolutions.Process();
Console.WriteLine($"=== Process Solutions end ===");
