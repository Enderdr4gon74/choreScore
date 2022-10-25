namespace choreScore.Controllers;

[ApiController]
[Route("/api/[controller]")]

public class ChoresController : ControllerBase
{
  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> Get()
  // public ActionResult<List<Chore>> Get()
  {
    try
    {
      // var chores = 0; // TODO fix
      return _choresService.getChores();
    }
    catch (Exception ex)
    {
       return BadRequest(ex.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Chore> GetChore(String id)
  {
    try
    {
      var chores = _choresService.getChore(id);
      return chores;
    }
    catch (Exception ex)
    {
       return BadRequest(ex.Message);
    }
  }

  [HttpPost]
  public ActionResult<Chore> AddChore([FromBody] Chore choreData)
  {
    try
    {
      var chore = _choresService.addChore(choreData);
      return chore;
    }
    catch (System.Exception ex)
    {
       return BadRequest(ex.Message);
    }
  }

  [HttpPut("{id}")]
  public ActionResult<Chore> EditChore([FromBody] Chore choreData, String id) 
  {
    try
    {
      var chore = _choresService.editChore(choreData, id);
      return chore;
    }
    catch (System.Exception ex)
    {
       return BadRequest(ex.Message);
    }
  }
}