﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.CrossCutting.Enumerators;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebUi.Controllers
{
    public abstract partial class BaseController : Controller
    {

        public BaseController()
        {
        }

        public String ErrorMessage
        {
            get { return TempData["ErrorMessage"] == null ? String.Empty : TempData["ErrorMessage"].ToString(); }
            set { TempData["ErrorMessage"] = value; }
        }

        public void SetCrudMessage(int? crud)
        {
            switch (crud)
            {
                case (int)EnumCrud.Created:
                    ViewBag.CrudMessage = (int)EnumCrud.Created;
                    break;
                case (int)EnumCrud.Updated:
                    ViewBag.CrudMessage = (int)EnumCrud.Updated;
                    break;
                case (int)EnumCrud.Deleted:
                    ViewBag.CrudMessage = (int)EnumCrud.Deleted;
                    break;
            }
        }
        public void SetNotifyMessage(int? notify, string message)
        {
            switch (notify)
            {
                case (int)EnumNotify.Error:
                    ViewBag.NotifyMessage = (int)EnumNotify.Error;
                    ViewBag.Notify = message;
                    break;
            }
        }
    }
}