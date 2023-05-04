using BlazorAppTelerik.Models;
using Microsoft.AspNetCore.Components;
using Telerik.Blazor.Components;
using Telerik.FontIcons;

namespace BlazorAppTelerik.Pages
{
    public partial class TreeviewTelerik : ComponentBase
    {


        public IEnumerable<TreeItem> FlatData { get; set; }

        public IEnumerable<object> ExpandedItems { get; set; }

        public string EventLog { get; set; } = string.Empty;

        public object EventTag { get; set; } = null;


        public TreeViewSelectionMode SelectionMode { get; set; } = TreeViewSelectionMode.Multiple;


        /// <summary>
        /// 
        /// </summary>
        protected override void OnInitialized()
        {
            LoadFlatData();
        }

        #region Events

        void OnClearLogClick()
        {
            EventLog = string.Empty;
        }


        public void OnSelect(IEnumerable<object> selectedItems)
        {
            var log = "Following items selected in the Tree View->";

            foreach (var item in selectedItems)
            {
                log += $"{(item as TreeItem).Text}->";
            }

            EventLog = EventLog.Insert(0, log);
        }

        public void OnExpand(TreeViewExpandEventArgs args)
        {
            var itemText = (args.Item as TreeItem).Text;
            var eventName = args.Expanded ? "Expand" : "Collapse ";
            var log = $" {eventName} event Item Text->{itemText}";

            EventLog = EventLog.Insert(0, log);
        }

        public void OnItemClick(TreeViewItemClickEventArgs args)
        {
            EventLog = string.Empty;

            var itemText = (args.Item as TreeItem).Text;

            object? itemTag = (args.Item as TreeItem).Tag;
            EventTag = itemTag;

            var log = $"Item-Click event Text->{itemText}";
            EventLog = EventLog.Insert(0, log);
        }

        public void OnItemDoubleClick(TreeViewItemDoubleClickEventArgs args)
        {
            var itemText = (args.Item as TreeItem).Text;
            var log = $"Item-DoubleClick Text->{itemText}";

            EventLog = EventLog.Insert(0, log);
        }

        public void OnItemContextMenu(TreeViewItemContextMenuEventArgs args)
        {
            var itemText = (args.Item as TreeItem).Text;
            var log = $"Item-ContextMenu event Text->{itemText}";

            EventLog = EventLog.Insert(0, log);
        }

        #endregion


        private void LoadFlatData()
        {
            List<TreeItem> items = new List<TreeItem>();

            items.Add(new TreeItem()
            {
                Id = 1,
                Text = "Project",

                ParentIdValue = null,
                HasChildren = true,

                Icon = FontIcon.Folder,
                Tag = new TreeItem()

            });
            items.Add(new TreeItem()
            {
                Id = 3,
                Text = "Implementation",

                ParentIdValue = 1,
                HasChildren = true,

                Icon = FontIcon.Folder,
                Tag = new TreeItem()
            });

            items.Add(new TreeItem()
            {
                Id = 5,
                Text = "index.js",

                ParentIdValue = 3,
                HasChildren = false,

                Icon = FontIcon.Js
            });
            items.Add(new TreeItem()
            {
                Id = 6,
                Text = "index.html",
                ParentIdValue = 3,
                HasChildren = false,
                Icon = FontIcon.Code,
                Tag = new TreeItem()
            });

            items.Add(new TreeItem()
            {
                Id = 7,
                Text = "styles.css",
                ParentIdValue = 3,
                HasChildren = true,
                Icon = FontIcon.Css
            });


            items.Add(new TreeItem()
            {
                Id = 2,
                Text = "Design",

                ParentIdValue = 1,
                HasChildren = true,

                Icon = FontIcon.Brush,
                Tag = new TreeItem()
            });

            items.Add(new TreeItem()
            {
                Id = 4,
                Text = "site.psd",

                ParentIdValue = 2,
                HasChildren = false,

                Icon = FontIcon.FilePsd
            });

            items.Add(new TreeItem()
            {
                Id = 8,
                Text = "document.pdf",
                ParentIdValue = 7,
                HasChildren = false,
                Icon = FontIcon.FilePdf,
                Tag = new TreeItem()

            });

            items.Add(new TreeItem()
            {
                Id = 10,
                Text = "document.xls",
                ParentIdValue = 7,
                HasChildren = true,
                Icon = FontIcon.FileExcel
            });

            items.Add(new TreeItem()
            {
                Id = 11,
                Text = "document2.xls",
                ParentIdValue = 10,
                HasChildren = false,
                Icon = FontIcon.FileExcel
            });


            FlatData = items;

            ExpandedItems = items.Take(3);
        }
    }


}

