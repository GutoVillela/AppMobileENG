using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace APP_LAB_ENG_SW.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [PrimaryKey]
        public string Login { get; set; }

        [NotNull]
        public string Senha { get; set; }
    }
}
