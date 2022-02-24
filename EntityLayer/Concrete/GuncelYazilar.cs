using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class GuncelYazilar : IEntity
	{
		[Key]
		public int YaziID { get; set; }
		[StringLength(300)]
		public String Title { get; set; }
		[StringLength(300)]
		public String File { get; set; }
		public DateTime DateYazi { get; set; }
	}
}
