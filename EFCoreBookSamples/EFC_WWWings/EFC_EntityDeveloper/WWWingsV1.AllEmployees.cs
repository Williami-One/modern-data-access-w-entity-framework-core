﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 30/12/2017 23:45:03
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;

namespace EFC_EntityDeveloper
{
    public partial class AllEmployees {

        public AllEmployees()
        {
            OnCreated();
        }

        public virtual int PersonID
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> HireDate
        {
            get;
            set;
        }

        public virtual System.Nullable<int> EmployeeNo
        {
            get;
            set;
        }

        public virtual System.Nullable<int> SupervisorPersonID
        {
            get;
            set;
        }

        public virtual string SurName
        {
            get;
            set;
        }

        public virtual string GivenName
        {
            get;
            set;
        }

        public virtual string Country
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> Birthday
        {
            get;
            set;
        }

        public virtual byte[] Photo
        {
            get;
            set;
        }

        public virtual string EMail
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
