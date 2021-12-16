﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_Roman_webApi.Domains
{
    public partial class Equipe
    {
        public Equipe()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEquipe { get; set; }
        public string NomeEquipe { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
