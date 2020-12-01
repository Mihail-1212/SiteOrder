using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteOrder.db_context
{
    public enum TechnicalTask_status
    {
        completed,  // исполненно
        canceled,   // отменено
        processing  // в обработке
    }

    public enum Logbook_userType
    {
        customer,   // заказчик
        executor    // исполнитель
    }

    public static class dbHelper
    {

    }
}
