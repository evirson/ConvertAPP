using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConvertAPP.Models
{
    [Table("TIPCLI")]
    public class TipoCliente
    {
        [Key]
        [Column("CODTIP")]
        public long codTip { get; set; }
        [Column("NOMTIP")]
        public String nomTip { get; set; }
        [Column("LOJLOG")]
        public long? lojLog { get; set; }
        [Column("TRMLOG")]
        public long? trmLog { get; set; }
        [Column("USRLOG")]
        public long? usrLog { get; set; }
        [Column("DATEXP")]
        public DateTime? datExp { get; set; }

    }
}
