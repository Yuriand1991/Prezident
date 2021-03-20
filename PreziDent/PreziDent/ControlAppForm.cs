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
                TypeProduct.name = typeProductsForm.NameTypeProducts.Text;
                db.type_product.Add(TypeProduct);
                db.Entry(TypeProduct).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        static public void OpenAddGroupServicesForm(IWin32Window owner)
        {
            GroupServicesForm groupServicesForm = new GroupServicesForm();
            DialogResult Result = groupServicesForm.ShowDialog(owner);

            if (Result == DialogResult.Cancel)
                return;

            using (PrezidentClinicEntities db = new PrezidentClinicEntities())
            {
                group_services GroupServices = new group_services();
                GroupServices.name = groupServicesForm.NameGroupServices.Text;
                db.group_services.Add(GroupServices);
                db.Entry(GroupServices).State = EntityState.Added;
                db.SaveChanges();
            }
        }

    }
}
