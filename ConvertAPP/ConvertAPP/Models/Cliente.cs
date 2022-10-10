using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConvertAPP.Models
{
    [Table("CADCLI")]
    public class Cliente
    {
        [Key]
        [Column("CODCLI")]
        public int? codCli { get; set; }
        [Column("CODLOJ")]
        public int? codLoj { get; set; }
        [Column("NOMCLI")]
        public string? nomCli { get; set; }
        [Column("DATNAS")]
        public DateTime? datNas { get; set; }
        [Column("CLIBLO")]
        public string? cliBlo { get; set; }
        [Column("CRELIB")]
        public string? creLib { get; set; }
        [Column("FISJUR")]
        public string? fisJur { get; set; }
        [Column("CODTP1")]
        public int? codTp1 { get; set; }
        [Column("CODTP2")]
        public int? codTp2 { get; set; }
        [Column("CPFCLI")]
        public string? cpfCli { get; set; }
        [Column("IDECLI")]
        public string? ideCli { get; set; }
        [Column("DATIDE")]
        public DateTime? datIde { get; set; }
        [Column("UF_IDE")]
        public string? uf_Ide { get; set; }
        [Column("ORGIDE")]
        public string? orgIde { get; set; }
        [Column("CARTRA")]
        public string? carTra { get; set; }
        [Column("NMINSS")]
        public string? nmInss { get; set; }
        [Column("ESTCIV")]
        public string? estCiv { get; set; }
        [Column("SEXCLI")]
        public string? sexCli { get; set; }
        [Column("NATCLI")]
        public string? natCli { get; set; }
        [Column("NOMPAI")]
        public string? nomPai { get; set; }
        [Column("NOMMAE")]
        public string? nomMae { get; set; }
        [Column("ENDRES")]
        public string? endRes { get; set; }
        [Column("NM_ENDRES")]
        public int? nm_EndRes { get; set; }
        [Column("BAIRES")]
        public string? baiRes { get; set; }
        [Column("CIDRES")]
        public string? cidRes { get; set; }
        [Column("ESTRES")]
        public string? estRes { get; set; }
        [Column("CEPRES")]
        public string? cepRes { get; set; }
        [Column("FONRES")]
        public string? fonRes { get; set; }
        [Column("CELULA")]
        public string? celula { get; set; }
        [Column("INFADC")]
        public string? infAdc { get; set; }
        [Column("EMAIL")]
        public string? eMail { get; set; }
        [Column("TIPCAS")]
        public string? tipCas { get; set; }
        [Column("RESDES")]
        public string? resDes { get; set; }
        [Column("VALALU")]
        public float? valAlu { get; set; }
        [Column("NM_ENDENT")]
        public int? nm_endEnt { get; set; }
        [Column("ENDENT")]
        public string? endEnt { get; set; }
        [Column("BAIENT")]
        public string? baiEnt { get; set; }
        [Column("CIDENT")]
        public string? cidEnt { get; set; }
        [Column("ESTENT")]
        public string? estEnt { get; set; }
        [Column("CEPENT")]
        public string? cepEnt { get; set; }
        [Column("FONENT")]
        public string? fonEnt { get; set; }
        [Column("NOMEMP")]
        public string? nomEmp { get; set; }
        [Column("CNPEMP")]
        public string? cnpEmp { get; set; }
        [Column("ENDEMP")]
        public string? endEmp { get; set; }
        [Column("BAIEMP")]
        public string? baiEmp { get; set; }
        [Column("CIDEMP")]
        public string? cidEmp { get; set; }
        [Column("ESTEMP")]
        public string? estEmp { get; set; }
        [Column("CEPEMP")]
        public string? cepEmp { get; set; }
        [Column("FONEMP")]
        public string? fonEmp { get; set; }
        [Column("RAMEMP")]
        public string? ramEmp { get; set; }
        [Column("ADMEMP")]
        public DateTime? admEmp { get; set; }
        [Column("CAREMP")]
        public string? carEmp { get; set; }
        [Column("SALEMP")]
        public float? salEmp { get; set; }
        [Column("NOMCJG")]
        public string? nomCjg { get; set; }
        [Column("DATNASCJ")]
        public DateTime? datNasCj { get; set; }
        [Column("CELULACJ")]
        public string? celulaCj { get; set; }
        [Column("EMAILCJ")]
        public string? eMailCj { get; set; }
        [Column("CPFCLICJ")]
        public string? cpfCliCj { get; set; }
        [Column("IDECLICJ")]
        public string? ideCliCj { get; set; }
        [Column("NATCLICJ")]
        public string? natCliCj { get; set; }
        [Column("NOMPAICJ")]
        public string? nomPaiCj { get; set; }
        [Column("NOMMAECJ")]
        public string? nomMaeCj { get; set; }
        [Column("NOMEMPCJ")]
        public string? nomEmpCj { get; set; }
        [Column("NM_ENDEMPCJ")]
        public int? nm_endEmpCj { get; set; }
        [Column("CNPEMPCJ")]
        public string? cnpEmpCj { get; set; }
        [Column("ENDEMPCJ")]
        public string? endEmpCj { get; set; }
        [Column("BAIEMPCJ")]
        public string? baiEmpCj { get; set; }
        [Column("CIDEMPCJ")]
        public string? cidEmpCj { get; set; }
        [Column("ESTEMPCJ")]
        public string? estEmpCj { get; set; }
        [Column("CEPEMPCJ")]
        public string? cepEmpCj { get; set; }
        [Column("FONEMPCJ")]
        public string? fonEmpCj { get; set; }
        [Column("RAMEMPCJ")]
        public string? ramEmpCj { get; set; }
        [Column("ADMEMPCJ")]
        public DateTime? admEmpCj { get; set; }
        [Column("CAREMPCJ")]
        public string? carEmpCj { get; set; }
        [Column("SALEMPCJ")]
        public float? salEmpCj { get; set; }
        [Column("REFPES1")]
        public string? refPes1 { get; set; }
        [Column("FONREFP1")]
        public string? fonRefP1 { get; set; }
        [Column("PRTREFP1")]
        public string? prtRefP1 { get; set; }
        [Column("REFPES2")]
        public string? refPes2 { get; set; }
        [Column("FONREFP2")]
        public string? fonRefP2 { get; set; }
        [Column("PRTREFP2")]
        public string? prtRefP2 { get; set; }
        [Column("REFCOM1")]
        public string? refCom1 { get; set; }
        [Column("FONREFC1")]
        public string? fonRefC1 { get; set; }
        [Column("REFCOM2")]
        public string? refCom2 { get; set; }
        [Column("FONREFC2")]
        public string? fonRefC2 { get; set; }
        [Column("LIMCRE")]
        public float? limCre { get; set; }
        [Column("MATCVN")]
        public string? matCvn { get; set; }
        [Column("DADBAN")]
        public string? dadBan { get; set; }
        [Column("CLIDES")]
        public DateTime? cliDes { get; set; }
        [Column("LOJALT")]
        public int? lojAlt { get; set; }
        [Column("LOJLOG")]
        public int? lojLog { get; set; }
        [Column("VCTFAT")]
        public int? vctFat { get; set; }
        [Column("TRMLOG")]
        public int? trmLog { get; set; }
        [Column("USRLOG")]
        public int? usrLog { get; set; }
        [Column("ULTALT")]
        public DateTime? ultAlt { get; set; }
        [Column("ON_OFF")]
        public int? on_Off { get; set; }
        [Column("DATEXP")]
        public DateTime? datExp { get; set; }
        [Column("LOJEXP")]
        public int? lojExp { get; set; }
        [Column("CODFRQ")]
        public int? codFrq { get; set; }
        [Column("CODOLD")]
        public string? codOld { get; set; }
        [Column("CODFUN")]
        public int? codFun { get; set; }
    }
}
