using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace WebApplicationPost.Controllers;
[Route("api/demo")]
//[ApiController]
public class HomeController : Controller
{	[Produces("application/json")]
	[HttpGet("demo1")]
    public IActionResult Demo1()
    {
		try
		{
			return Ok(new
			{
				Msg="Hello"
			});
		}
		catch (Exception)
		{

			
		return BadRequest();
		}
      //  return View();
    }
	[Produces("application/json")]
	[HttpGet("demo2/{id}")]
    public IActionResult Demo2(int id)
    {
		try
		{
			return Ok(new
			{
				Msg= id+"23H"
			});
		}
		catch (Exception)
		{

			
		return BadRequest();
		}
      //  return View();
    }
	[Produces("application/json")]
	[HttpGet("demo3")]
    public IActionResult Demo3(int id)
    {
		try
		{
			return Ok(new
			{
				Msg= id+"23H"
			});
		}
		catch (Exception)
		{

			
		return BadRequest();
		}
      //  return View();
    }
}
