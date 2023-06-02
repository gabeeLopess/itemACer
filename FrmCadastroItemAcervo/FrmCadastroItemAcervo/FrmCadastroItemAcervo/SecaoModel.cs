using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmCadastroItemAcervo
{
    [Table("MvtBIBSecao")]
    public class SecaoModel
    {
        [Key()]
        public string CodSecao { get; set; }
        public string DescricaoSecao { get; set; }
    }
}
