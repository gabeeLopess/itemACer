using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmCadastroItemAcervo
{
    [Table("mvtBiibItemAcervo")]
    public class ItemAcervoModel
    {
        [Key()]
        public string CodItem { get; set; }
        public string Nome { get; set; }
        public string TipoItem { get; set; }
        public string NomeColecao { get; set; }
        public string NumExemplar { get; set; }
        public string Volume { get; set; }
        public string AnoEdicao { get; set; }
        public string Localizacao { get; set; }
        public string Status { get; set; }

        [ForeignKey("mvtBiibAutor")]
        [Column("codAutor")]
        public string CodAutor { get; set; }
        public virtual AutorModel AutorModel { get; set; }

        [ForeignKey("MvtBIBLocal")]
        [Column("codLocal")]
        public string CodLocal { get; set; }
        public virtual LocalModel LocalModel { get; set; }

        [ForeignKey("MvtBIBSecao")]
        [Column("codSecao")]
        public string CodSecao { get; set; }
        public virtual SecaoModel SecaoModel { get; set; }

        [ForeignKey("mvtBiibEditora")]
        [Column("codEditora")]
        public string CodEditora { get; set; }
        public virtual EditoraModel EditoraModel { get; set; }
        public object Local { get; internal set; }
    }

}

