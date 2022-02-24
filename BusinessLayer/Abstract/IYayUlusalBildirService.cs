using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IYayUlusalBildirService
	{
        List<YayUlusalBildir> GetAll();
        List<YayUlusalBildir> GetYayUlusalBildirByID(int id);
        YayUlusalBildir GetByID(int id);
        void YayUlusalBildirAdd(YayUlusalBildir yayUlusalBildir);
        void YayUlusalBildirUpdate(YayUlusalBildir yayUlusalBildir);
        void YayUlusalBildirDelete(YayUlusalBildir yayUlusalBildir);
    }
}
