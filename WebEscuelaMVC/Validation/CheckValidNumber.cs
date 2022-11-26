using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace WebEscuelaMVC.Validation
{
    public class CheckValidNumber:ValidationAttribute
    {

        public CheckValidNumber() 
        {
            ErrorMessage = "El numero ingresado debe ser mayor a 100";
        }

        public override bool IsValid(object value)
        {
            int numero = (int)value;
            bool flag = true;
            if(numero <100) flag= false;

            return flag;
        }
    }
}