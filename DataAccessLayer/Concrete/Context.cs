using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		public DbSet<About> Abouts { get; set; }
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Kitap> Kitaps { get; set; }
		public DbSet<AkacemikCV> AkacemikCVs { get; set; }
		public DbSet<GuncelYazilar> GuncelYazilars { get; set; }
		public DbSet<Makale> Makales { get; set; }
		public DbSet<Editorluk> Editorluks { get; set; }
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<Atiflar> Atiflars { get; set; }
		public DbSet<GazeteDergi> GazeteDergis { get; set; }
		public DbSet<Konusmaci> Konusmacis { get; set; }
		public DbSet<MesKurUye> MesKurUyes { get; set; }
		public DbSet<OturumBaskanlik> OturumBaskanliks { get; set; }
		public DbSet<SemKonBilDanKurUye> SemKonBilDanKurUyes { get; set; }
		public DbSet<YayUlusalBildir> YayUlusalBildirs { get; set; }
		public DbSet<YayUluslararsBildir> YayUluslararsBildirs { get; set; }
	}
}
