using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;
        public WeatherForecastController(ILoggerManager logger)
        {
            logger = logger;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("��� �������������� ��������� �� ������ ����������� ��������.");


            _logger.LogDebug("��� ���������� ��������� �� ������ ����������� ��������.");


            _logger.LogWarn("��� ��������� �������������� �� ������ ����������� ��������.");


            _logger.LogError("��� ��������� �� ������ �� ������ ����������� ��������.");
        return new string[] { "value1", "value2" };
        }
    }
}