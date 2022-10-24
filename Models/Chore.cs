namespace choreScore.models;

public class Chore 
{
  public String Id { get; private set; }
  public String Name { get; private set; }
  public Boolean IsComplete { get; private set; }
  public Chore(String name, Boolean isComplete) 
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    IsComplete = isComplete;
  }
}