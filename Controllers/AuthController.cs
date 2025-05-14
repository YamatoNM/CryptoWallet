﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CryptoWallet.Models.AuthModel;
using CryptoWallet.BusinessLogic.Interfaces;
using CryptoWallet.Domain.Model.User;
using CryptoWallet.BusinessLogic.BLStructure;

namespace CryptoWallet.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuth _auth;


        public AuthController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _auth = bl.GetAuthBL();
        }

        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Auth(UserDataLogin login)
        {

            var data = new ULoginData
            {
                Username = login.Username,
                Password = login.Password
            };

            string token = _auth.UserAuthLogic(data);

            return View();
        }
    }
}