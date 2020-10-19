using SalesSystem.BLL.Interfaces;
using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BLL.UserOperations
{
 public   class OperationsBase : Ioperations
    {
        protected readonly SalessystemContext context;

        public OperationsBase(SalessystemContext contexts)
        {

            context = contexts;
        }
    }

}
