using System;

namespace HPlusSport.API.Classes
{
    public class QueryParameters
    {
        const int _maxSize = 100;
        private int _size = 50;

        public int Page { get; set; }

        public int Size
        {
            get => _size;
            set => _size = Math.Min(_maxSize, value);
        }

        public string SortBy { get; set; } = "Id";

        private string _sortOrder = "asc";
        public string SortOrder
        {
            get => _sortOrder;
            set
            {
                if (value == "asc" || value == "desc")
                    _sortOrder = value;
            }
        }
    }
}