namespace choreScore.Controllers;

[ApiController]
[Route("/api/[controller]")]

public class ChoresController : ControllerBase
{
  [HttpGet]
  public ActionResult<List<Chore>> Get()
  // public ActionResult<List<Chore>> Get()
  {
    try
    {
      // var chores = 0; // TODO fix
      // return chores;
    }
    catch (Exception ex)
    {
       return BadRequest(ex.Message);
    }
  }
}