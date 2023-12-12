using System.Globalization;

namespace MVC.Models
{
    public class Compromisso
    {
        public int Id { get; set; }

        public string Data { get; set; }

        public Local Local { get; set; }

        public Contato Contato { get; set; }

        public string Situacao { get; set; }
    }
}
