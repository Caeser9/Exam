using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Fete
    {
        [Key]
        public int IdFete { get; set; }
        [Required(ErrorMessage ="Description Fete Obligatoire")]
        public string Description{ get; set; }
        public TypeFete Type{ get; set; }
        [Range(1,250)]
        public int NbInvitesMax { get; set; }
        public int Duree { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateFete { get; set; }

        public virtual IList<Invite> Invites { get; set; }  

        public virtual Salle salle { get; set; }
        public virtual IList<Invitation> Invitations { get; set;}
    }
}
