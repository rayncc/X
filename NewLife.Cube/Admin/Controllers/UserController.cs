﻿using System;
using System.ComponentModel;
using System.Web.Mvc;
using NewLife.Cube.Controllers;
using XCode.Membership;

namespace NewLife.Cube.Admin.Controllers
{
    [DisplayName("用户")]
    public class UserController : EntityController<UserX> { }
}