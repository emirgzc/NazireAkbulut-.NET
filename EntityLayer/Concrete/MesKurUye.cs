using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class MesKurUye : IEntity
	{
		[Key]
		public int MesKurId { get; set; }
		[StringLength(300)]
		public String Title { get; set; }
		public bool Status { get; set; }
	}
}
