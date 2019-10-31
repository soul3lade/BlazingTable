using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingTable.Models
{
    public class BlazingTableColumn
    {
        /// <summary>
        /// Name of property to associate with
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Value to display in the table head
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Order to display column in
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Allows sorting by the column
        /// </summary>
        public bool Sortable { get; set; }

        /// <summary>
        /// Adds the column into the filter menu
        /// </summary>
        public bool Filterable { get; set; }

        /// <summary>
        /// Allows the user to show/hide the column
        /// </summary>
        public bool AllowHide { get; set; }

        /// <summary>
        /// Defines whether the column is currently hidden
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// Allows the column to be dynamically resized
        /// </summary>
        public bool AllowResize { get; set; }

        public BlazingTableColumn()
        {
            Sortable = true;
            Filterable = true;
            Hidden = false;
            AllowHide = true;
            AllowResize = true;
        }
    }
}
