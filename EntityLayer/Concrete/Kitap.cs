using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Kitap : IEntity
	{
		[Key]
		public int KitapID { get; set; }
		[StringLength(300)]
		public String KitapTitle { get; set; }
		public String KitapDesc { get; set; }
		[StringLength(150)]
		public String KitapImage { get; set; }
		public DateTime KitapDate { get; set; }
		public bool Status { get; set; }
	}
}
