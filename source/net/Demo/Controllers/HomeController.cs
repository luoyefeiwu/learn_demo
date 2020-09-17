using System;
using System.Collections.Generic;
using Demo.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public String Index()
        {
            return "你好啊！";
        }
        [HttpPost]
        public int Add()
        {
            return 1;
        }

        public List<Person> getAll()
        {
            List<Person> list = new List<Person>();

            return list;
        }


    }
}
