using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Makale : IEntity
	{
		[Key]
		public int MakaleID { get; set; }
		[StringLength(300)]
		public String MakaleTitle { get; set; }
		public String MakaleDesc { get; set; }
		public DateTime MakaleDate { get; set; }
		public bool MakaleStatus { get; set; }
	}
}
