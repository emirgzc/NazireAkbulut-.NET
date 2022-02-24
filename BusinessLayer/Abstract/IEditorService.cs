using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IEditorService
    {
        List<Editorluk> GetAll();
        /*List<Editor> GetOrderByDate();*/
        List<Editorluk> GetEditorlukByID(int id);
        Editorluk GetByID(int id);
        void EditorlukAdd(Editorluk editorluk);
        void EditorlukUpdate(Editorluk editorluk);
        void EditorlukDelete(Editorluk editorluk);
    }
}
