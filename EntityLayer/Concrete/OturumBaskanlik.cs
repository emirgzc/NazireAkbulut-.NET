using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class OturumBaskanlik : IEntity
	{
		[Key]
		public int OturumBaskanlikID { get; set; }
		[StringLength(200)]
		public String File { get; set; }
	}
}
