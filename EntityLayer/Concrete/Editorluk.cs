using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Editorluk : IEntity
	{
		[Key]
		public int EditID { get; set; }
		[StringLength(300)]
		public String EditTitle { get; set; }
		public String EditDesc { get; set; }
		[StringLength(150)]
		public String EditImage { get; set; }
		public DateTime EditDate { get; set; }
		public bool Status { get; set; }
	}
}
