using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls.Extensions
{
    public static class SortingExtensions
    {
        public static IEnumerable<TSource> OrderBySortString<TSource>(this IEnumerable<TSource> collection, string sortString)
        {
            var obj = typeof(TSource);
            var properties = obj.GetProperties();

            sortString = sortString.Replace("[", "").Replace("]", "");
            var sortValues = sortString.Split(',');

            foreach (var property in properties)
            {
                foreach (var sortValue in sortValues)
                {
                    var sortDef = sortValue.Trim().Split(' ');
                    if (sortDef.First() == property.Name)
                    {
                        switch (sortDef.Last())
                        {
                            case "ASC":
                                collection = collection.OrderBy(x => x.GetType()
                                                                      .GetProperty(sortDef.First())
                                                                      .GetValue(x, null))
                                                        .ToList();
                                break;
                            case "DESC":
                                collection = collection.OrderByDescending(x => x.GetType()
                                                                                .GetProperty(sortDef.First())
                                                                                .GetValue(x, null))
                                                        .ToList();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            return collection;

        }
    }

    public static class ControlExtensions
    {
        public static void BindToEnum<TEnum>(this DataGridViewComboBoxColumn comboBox)
        {
            foreach (var item in Enum.GetValues(typeof(TEnum)))
            {
                comboBox.Items.Add(item);
            }
        }
    }
}
