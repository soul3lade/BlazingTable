using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingTable.Models
{
    public class BlazingTableSettings<T>
    {
        public string Title { get; set; }

        public List<T> Data { get; set; }

        /// <summary>
        /// Defines custom settings for columns.  If null, defaults will be used instead
        /// </summary>
        public List<BlazingTableColumn> Columns { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }


    }
}
