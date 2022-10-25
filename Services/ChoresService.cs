namespace choreScore.Services;




public class ChoresService
{
  private readonly FakeDb _db;

  public List<Chore> getChores()
  {
    return _db.Chores;
  }

  public Chore getChore(String id)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    if (chore == null) {
      throw new Exception("Invalid or bad Chore Id");
    }
    return chore;
  }

  public Chore addChore(Chore choreData)
  {
    _db.Chores.Add(choreData);
    return choreData;
  }

  public Chore editChore(Chore choreData, String id)
  {
    // TODO find out how to edit with C# ?!?!?!?!?!?
    return null;
  }
}