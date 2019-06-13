using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Database;

namespace CourseWork
{
    public class Constants
    {
        public const int DefaultIndex = -1;
        public const string UNKNOWN = "UNKNOWN";
        public const double ROW_HEIGHT = 20;

        public const double WIDTH_PADDING = 3;
        public const double SYMBOL_WIDTH = 10;
        public delegate Form FormGetter();
        public delegate bool Validator();

        public static string GetTableName<T>() where T : IDbItem, new()
        {
            return new T().DataTableName;
        }

        public static string GetIdFieldName<T>() where T : IDbItem, new()
        {
            return new T().IdFieldName;
        }

        public static IEnumerable<T> Sort<T>(IEnumerable<T> data) where T : IComparable
        {
            T[] arr = data.ToArray();
            Array.Sort(arr);
            return arr.ToList();
        }

        public static int[] GetFieldsSizes(params string[] Values)
        {
            int[] Widths = new int[Values.Length];
            for (int i = 0; i < Values.Length; i++)
                Widths[i] = (int)(Values[i].Length * SYMBOL_WIDTH);
            return Widths;
        }

        public static DataTable CreateDataTableOf(IEnumerable<ModelItem> items)
        {
            if (items == null || items.Count() == 0)
                return new DataTable();

            DataTable table = items.First().GetViewConfiguration();

            foreach (ModelItem item in items)
                item.AddTo(table);

            return table;
        }

        public static int[] GetMaxWidths(IEnumerable<ModelItem> items, DataGridView dgw)
        {
            if (items == null || items.Count() == 0)
                return null;

            int[] MaxWidths = new int[dgw.Columns.Count];
            for (int i = 0; i < dgw.Columns.Count; i++)
                MaxWidths[i] = dgw.Columns[i].HeaderCell.Value.ToString().Length;

            foreach (ModelItem item in items)
                for (int i = 0; i < MaxWidths.Length && i < item.ColumnMaxSymbolCount.Count; i++)
                    if (item.ColumnMaxSymbolCount[i] > MaxWidths[i])
                        MaxWidths[i] = item.ColumnMaxSymbolCount[i];

            return MaxWidths;
        }

        public static void ConfigureGridSizes(IEnumerable<ModelItem> items, DataGridView dgw)
        {
            if (items == null || items.Count() == 0)
                return;

            int[] MaxWidths = GetMaxWidths(items, dgw);
            for (int i = 0; i < MaxWidths.Length && i < dgw.Columns.Count; i++)
                dgw.Columns[i].Width = (int)(MaxWidths[i] * SYMBOL_WIDTH + WIDTH_PADDING * 2);

            dgw.RowTemplate.Height = (int)(items.Max(item => item.RowCount) * ROW_HEIGHT);
        }

        public static void FillDataGrid(IEnumerable<ModelItem> items, DataGridView dgw)
        {
            dgw.DataSource = Constants.CreateDataTableOf(items);
            Constants.ConfigureGridSizes(items, dgw);

            foreach (DataGridViewColumn C in dgw.Columns)
                C.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public static string FormatDate(DateTime dt)
        {
            return dt.Year + "-" + dt.Month + "-" + dt.Day;
        }
    }
}
