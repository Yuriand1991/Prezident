using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreziDent
{
    public partial class CabinetOrderForm : PreziDent.AppFrom
    {
        private List<OrderItemView> Items;
        public CabinetOrderForm()
        {
            InitializeComponent();
            Items = new List<OrderItemView> { };
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            AddServiceToOrderForm addServiceToOrderForm = new AddServiceToOrderForm();

            DialogResult Result = addServiceToOrderForm.ShowDialog(this);

            int OrderID;

            if (Result == DialogResult.Cancel)
                return;

            order Order = new order
            {
                count = Convert.ToInt32(addServiceToOrderForm.Count.Text),
                number_tooth = Convert.ToInt32(addServiceToOrderForm.NumberTooth.Text),
                patient_id = 0 //TODO потом сделать по нормальному
            };

            DataBase.db.Entry(Order).State = EntityState.Added;
            DataBase.db.SaveChanges();
            OrderID = Order.id;

            orders_services OrderItem = new orders_services
            {
                order_id = OrderID,
                service_id = addServiceToOrderForm.SelectServiceID,
                name_service = addServiceToOrderForm.ServiceName.Text,
                price_service = Convert.ToDecimal(addServiceToOrderForm.Price.Text)
            };

            DataBase.db.Entry(OrderItem).State = EntityState.Added;
            DataBase.db.SaveChanges();

            using (PrezidentClinicEntities db = new PrezidentClinicEntities())
            {
                var orderItem = db.orders_services.Where(os => os.order_id == OrderID).Join(db.orders,// второй набор
                                                                            os => os.order_id, // свойство-селектор объекта из первого набора
                                                                            o => o.id, // свойство-селектор объекта из второго набора
                                                                            (os, o) => new OrderItemView{ name_service = os.name_service,
                                                                                price_service = os.price_service,
                                                                                number_tooth = o.number_tooth,
                                                                                count = o.count,
                                                                                total_price_service = o.count * os.price_service
                                                                            });//.ToList(); // результат

                foreach(OrderItemView oi in orderItem)
                    Items.Add(oi);

                OrdersServicesView.DataSource = Items;
            }

        }
    }
}
