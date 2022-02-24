using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntityLayer.Concrete
{
	public class GazeteDergi : IEntity
	{
		[Key]
		public int GazID { get; set; }
		[StringLength(200)]
		public String Title { get; set; }
		public bool Status { get; set; }
	}
}
