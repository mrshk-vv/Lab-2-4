using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using BaseExporter.Attributes;

namespace BaseExporter.Entity
{
    public class TableConfig<T>
    {
        
        public List<string> DisplayedColumns { get; private set; }

        public string Name { get; private set; }

        public TableConfig()
        {
            SetName();
            SetDisplayedColumns();
        }

        private void SetName()
        {
            Name  = (System.Attribute.GetCustomAttribute(typeof(T), typeof(TableNameAttribute)) as TableNameAttribute)?.Name ?? "???";
        }

        private void SetDisplayedColumns()
        {
            var properties = typeof(T).GetProperties().Where(
                prop => Attribute.IsDefined(prop, typeof(DisplayNameAttribute))).ToList();

            var displayedColumns = properties.Select(p =>
                p.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute);

            var result = displayedColumns.Select(x => x?.DisplayName).ToList();

            result.Insert(0, result.Last());
            result.RemoveAt(result.Count - 1);

            DisplayedColumns = result;

        }
    }
}
