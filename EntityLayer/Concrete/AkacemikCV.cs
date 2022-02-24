using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class AkacemikCV : IEntity
	{
		[Key]
		public int CvID { get; set; }
		[StringLength(150)]
		public String File { get; set; }
		public bool Status { get; set; }
	}
}
