using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.Domain
{
    public class Club
    {

        public Club()
        {
            Players = new List<Player>();
        }
        public List<Player> Players { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        [Column(TypeName ="date")]
        public DateTime DateOfEstablishment { get; set; }
        public string History { get; set; }
        public League League { get; set; }


    }
}
