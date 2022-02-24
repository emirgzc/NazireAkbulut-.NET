using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntityLayer.Concrete
{
	public class Konusmaci : IEntity
	{
		[Key]
		public int KonusmaciID { get; set; }
		[StringLength(200)]
		public String File { get; set; }
	}
}
