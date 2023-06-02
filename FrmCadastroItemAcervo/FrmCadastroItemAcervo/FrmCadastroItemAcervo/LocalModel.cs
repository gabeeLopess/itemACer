using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmCadastroItemAcervo
{
    [Table("MvtBIBLocal")]
    public class LocalModel
    {
        [Key()]
        public string CodLocal { get; set; }
        public string NomeLocal { get; set; }
    }
}
