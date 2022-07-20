using AutoAtendimento_Hospitais.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoAtendimento_Hospitais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : Controller
    {

        private static List<Paciente> pacientes = new List<Paciente>();


        [HttpPost]    
        public IActionResult AdicionaPaciente ([FromBody] Paciente paciente)
        {
            pacientes.Add(paciente);
            return CreatedAtAction(nameof(RecuperaPacientePorCPF),new { Cpf = paciente.CPF }, paciente);
        }

        [HttpGet]
        public IEnumerable<Paciente> RecuperaPaciente()
        {
            return pacientes;
        }

        [HttpGet("{cpf}")]
        public IActionResult RecuperaPacientePorCPF(string cpf)
        {
            Paciente paciente = pacientes.FirstOrDefault(paciente => paciente.CPF.Equals(cpf));
            if(paciente != null)
            {
                return Ok(paciente);
            }
            return NotFound();
        }
       
    }

}
