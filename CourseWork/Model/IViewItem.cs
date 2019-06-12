using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CourseWork.Model
{
    public interface IViewItem
    {
        string ViewTableName { get; }
        void AddTo(DataTable table);
        DataTable GetViewConfiguration();
    }
}
