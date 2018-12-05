using System.ComponentModel.DataAnnotations;

namespace Aqua.Models
{
    public class Rybka
    {
        [Key]
        public int IDRybka { get; set; }
        public string Nazwa { get; set; }
        public int? ObrazekMax { get; set; }
        public int? ObrazekMin { get; set; }
        public string Opis { get; set; }
        public string PochodzenieOpis { get; set; }
        public string CharakterystykaOpis { get; set; }
        public string OdzywianieOpis { get; set; }
        public string AkwariumOpis { get; set; }
        public string RozmnazanieOpis { get; set; }
        public int? Video { get; set; }
        public string NazwaLacinska { get; set; }
        public string Synonim { get; set; }
        public string RozmiarUwagi { get; set; }
        public int? DlugoscZyciaOd { get; set; }
        public int? DlugoscZyciaDo { get; set; }
        public int? MinPojemnoscAkwa { get; set; }
        public int? MinDlugoscAkwa { get; set; }
        public int? WodaTempOd { get; set; }
        public int? WodaTempDo { get; set; }
        public int? WodapHOd { get; set; }
        public int? WodapHDo { get; set; }
        public int? TwardoscOd { get; set; }
        public int? TwardoscDo{ get; set; }














    }
}
