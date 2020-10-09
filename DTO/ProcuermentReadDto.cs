using System.ComponentModel.DataAnnotations;


namespace Procuerment.Dtos
{
    public class ProcuermentReadDto
    {

        public string name { get; set; }


        public string value { get; set; }

        public int price { get; set; }

        public string vendor { get; set; }
    }
}