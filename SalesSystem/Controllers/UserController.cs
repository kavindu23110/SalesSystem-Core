using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.BLL.DTO;
using SalesSystem.BLL.Interfaces;
using SalesSystem.BLL.UserOperations;
using SalesSystem.DAL;
using SalesSystem.Helpers;
using SalesSystem.Interfaces;
using SalesSystem.Models;

namespace SalesSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ViewModelDataFill datafill;

        public UserController(IMapper mapper,IDataRetrival dataRetrival)
        {
            _mapper = mapper;
            datafill = new ViewModelDataFill(dataRetrival);
        }

        public IActionResult Index()
        {
            return View();
        }   
        public IActionResult Login(UserViewModel userView)
        {
            if (ModelState.IsValid)
            {
                var DTO = new DTO_User();
                _mapper.Map(userView, DTO);

                (var result,var user)=new SalesSystem.BLL.DefinitionObjects.User().Login(DTO);
                if (result)
                {
                    TempData[BLL.BOD.CommonValues.Success] = true;
                    return RedirectToAction(nameof(Registration));
                }
            }
            return View();
        }


        public IActionResult Registration()
        {
            UserViewModel userViewModel = new UserViewModel();
            datafill.FillUserViewModel(ref userViewModel);
            return View(userViewModel);

        }
        public IActionResult RegistrationProcess(UserViewModel userView,[FromServices] Ioperations ioperations)
        {
            
            if (ModelState.IsValid)
            {
                var DTO = new DTO_User();
                _mapper.Map(userView, DTO);
                if (new SalesSystem.BLL.DefinitionObjects.User().Register(DTO))
                {
                    TempData[BLL.BOD.CommonValues.Success] = true;
                    return RedirectToAction(nameof(Registration));
                }

            }
         
            return View("Registration",userView);
        }


    }
}
