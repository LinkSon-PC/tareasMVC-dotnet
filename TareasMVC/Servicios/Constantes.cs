﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace TareasMVC.Servicios
{
    public class Constantes
    {
        public const string RolAdmin = "admin";
        public static readonly SelectListItem[] CulturasUIsoportadas = new SelectListItem[]
        {
            new SelectListItem{Value = "es", Text = "Español"},
            new SelectListItem{Value = "en", Text = "English"}
        };
    }
}
