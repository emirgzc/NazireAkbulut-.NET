using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class EditorlukManager : IEditorService
	{
		IEditorDal _editorlukDal;

		public EditorlukManager(IEditorDal editorlukDal)
		{
			_editorlukDal = editorlukDal;
		}
		public List<Editorluk> GetAll()
		{
			return _editorlukDal.GetAll();
		}

		public Editorluk GetByID(int id)
		{
			return _editorlukDal.Get(x => x.EditID == id);
		}

		public List<Editorluk> GetEditorlukByID(int id)
		{
			return _editorlukDal.GetAll(x => x.EditID == id);
		}

		public void EditorlukAdd(Editorluk editorluk)
		{
			_editorlukDal.Add(editorluk);
		}

		public void EditorlukDelete(Editorluk editorluk)
		{
			_editorlukDal.Delete(editorluk);
		}

		public void EditorlukUpdate(Editorluk editorluk)
		{
			_editorlukDal.Update(editorluk);
		}
	}
}
