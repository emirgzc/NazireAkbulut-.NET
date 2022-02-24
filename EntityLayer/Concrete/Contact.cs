using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Contact : IEntity
	{
		[Key]
		public int ContactID { get; set; }
		[StringLength(150)]
		public String NameSurname { get; set; }
		[StringLength(100)]
		public String Email { get; set; }
		[StringLength(300)]
		public String Subject { get; set; }
		public String Message { get; set; }
		public DateTime ContactDate { get; set; }
	}
}
