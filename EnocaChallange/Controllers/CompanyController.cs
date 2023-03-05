using EnocaChallange.Application.Repositories;
using EnocaChallange.Application.ViewModels.Company;
using EnocaChallange.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EnocaChallange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        readonly private ICompanyWriteRepository _companyWriteRepository;
        readonly private ICompanyReadRepository _companyReadRepository;

        public CompanyController(ICompanyWriteRepository companyWriteRepository, ICompanyReadRepository companyReadRepository)
        {
            _companyWriteRepository = companyWriteRepository;
            _companyReadRepository = companyReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_companyReadRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCompany model)
        {
            await _companyWriteRepository.AddAsync(new()
            {

                Name = model.Name,
                ApprovalStatus = model.ApprovalStatus,
                OrderStartTime = model.OrderStartTime,
                OrderFinishTime = model.OrderFinishTime,


            });
            await _companyWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateCompany model)
        {

            Company company = await _companyReadRepository.GetByIdAsync(model.Id);
            company.ApprovalStatus = model.ApprovalStatus;
            company.OrderStartTime = model.OrderStartTime;
            company.OrderFinishTime = model.OrderFinishTime;
            await _companyWriteRepository.SaveAsync();
            return Ok();
        }

    }


}
