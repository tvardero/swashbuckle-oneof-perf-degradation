using Microsoft.AspNetCore.Mvc;

[ApiController, Route("zoo")]
public class ZooController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Zoo), 200)]
    public IActionResult GetWholeZoo()
    {
        var zoo = new Zoo();

        return Ok(zoo);
    }

    [HttpGet("{name:alpha}")]
    public IActionResult GetAnimalByName(string name)
    {
        var zoo = new Zoo();
        var animal = zoo.Animals.FirstOrDefault(a => a.Name == name);

        return Ok(animal);
    }

    [HttpPost("animals")]
    public IActionResult CreateAnimal(AnimalBase animal)
    {
        return CreatedAtAction(nameof(GetAnimalByName), new { name = animal.Name }, animal);
    }
}