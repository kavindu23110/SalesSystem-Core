using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.BLL.DTO;
using SalesSystem.BLL.Interfaces;
using SalesSystem.Helpers;
using SalesSystem.Models;

namespace SalesSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ViewModelDataFill datafill;
        //Get Services From DI
        public UserController(IMapper mapper, IDataRetrival dataRetrival)
        {
            _mapper = mapper;
            datafill = new ViewModelDataFill(dataRetrival);
        }
        //Return Login View
        public IActionResult Index()
        {
            return View();
        }

        //Return Login View

        //Get Login Request
        [HttpPost]
        public IActionResult Login(UserViewModel userView)
        {
            if (ModelState.IsValid)
            {
                //valid User Login Requests Map to DTO
                var DTO = new DTO_User();
                _mapper.Map(userView, DTO);

                (var result, var user) = new SalesSystem.BLL.DefinitionObjects.User().Login(DTO);
                if (result)
                {
                    //Valid Users Are Stored In the Session
                    SessionManager.Set<DTO_User>(HttpContext.Session, "LoggedUser", user);
                    TempData[BLL.BOD.CommonValues.UnSuccess] = true;
                    return RedirectToAction(nameof(Registration));
                }
                else
                {
                    TempData[BLL.BOD.CommonValues.UnSuccess] = true;
                }
            }
          
            return View("Index", userView);
        }

        //Provide Registration view with provide  Dropdown values
        public IActionResult Registration()
        {

            UserViewModel userViewModel = new UserViewModel();
            datafill.FillUserViewModel(ref userViewModel);
            return View(userViewModel);

        }
        //User Registration Request
        [HttpPost]
        public IActionResult RegistrationProcess(UserViewModel userView, [FromServices] Ioperations ioperations)
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

            return View("Registration", userView);
        }


    }
}
