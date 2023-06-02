using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmCadastroItemAcervo
{

    [Table("mvtBiibAutor")]

    public class AutorModel
    {
        [Key()]
        public string CodAutor { get; set; }
        public string NomeAutor { get; set; }


    }
}
