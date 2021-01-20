using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreziDent
{
    class ControlAppForm
    {
        static public void OpenAddTypeProductForm(IWin32Window owner)
        {
            TypeProductsForm typeProductsForm = new TypeProductsForm();
            DialogResult Result = typeProductsForm.ShowDialog(owner);

            if (Result == DialogResult.Cancel)
                return;

            using (PrezidentClinicEntities db = new PrezidentClinicEntities())
            {
                type_product TypeProduct = new type_product();
                TypeProduct.name = typeProductsForm.NameTypeProduct.Text;
                db.type_product.Add(TypeProduct);
                db.Entry(TypeProduct).State = EntityState.Added;
                db.SaveChanges();
            }
        }

    }
}
