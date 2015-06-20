using project_AK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt_AK.Models
{
    public class MyViewModel
    {
        public RegisterViewModel RegisterViewModel { get; set; }
        public LoginViewModel LoginViewModel { get; set; }
        public MessageViewModel MessageViewModel { get; set; }
    }



    public class MessageViewModel
    {
        public string Title { get; set; }
        public string Message { get; set; }

    }
}