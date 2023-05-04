using Telerik.FontIcons;

namespace BlazorAppTelerik.Models;


    public class TreeItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? ParentIdValue { get; set; }
        public bool HasChildren { get; set; }
        public FontIcon? Icon { get; set; }
        public object? Tag { get; set; }

    }

