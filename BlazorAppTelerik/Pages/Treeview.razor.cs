using Microsoft.AspNetCore.Components;

namespace BlazorAppTelerik.Pages;

public partial class Treeview :ComponentBase
{

    public IEnumerable<TreeItem> FlatData { get; set; }
    public IEnumerable<object> ExpandedItems { get; set; } = new List<TreeItem>();
    public IEnumerable<object> SelectedItems { get; set; } = new List<TreeItem>();

    int? ItemToExpand { get; set; }
    Random rnd { get; set; } = new Random();


    protected override void OnInitialized()
    {
        FlatData = LoadFlat();

        ItemToExpand = rnd.Next(1, FlatData.Count() + 1);
    }


    void ExpandItem()
    {
        var allItemsToExpand = new List<TreeItem>();
        var leafItem = FlatData.Where(x => x.Id == ItemToExpand).FirstOrDefault();
        int? parentId = null;
        if (leafItem != null)
        {
            // item selection is not required for expanding
            SelectedItems = new List<TreeItem>() { leafItem };
            allItemsToExpand.Add(leafItem);
            parentId = leafItem.ParentId;
            while (parentId != null)
            {
                var parentItem = FlatData.Where(x => x.Id == parentId).FirstOrDefault();
                allItemsToExpand.Add(parentItem);
                parentId = parentItem.ParentId;
            }
        }
        ExpandedItems = allItemsToExpand;
    }

    void ExpandRoot()
    {
        ExpandedItems = FlatData.Where(x => x.ParentId == null && x.HasChildren == true);
    }

    void ExpandAll()
    {
        ExpandedItems = FlatData.Where(x => x.HasChildren == true);
    }

    void CollapseAll()
    {
        ExpandedItems = new List<TreeItem>();
        SelectedItems = new List<TreeItem>();
    }

           

    int TreeLevels { get; set; } = 5;
    int ItemsPerLevel { get; set; } = 4;
    int IdCounter { get; set; } = 1;


    List<TreeItem> LoadFlat()
    {
        List<TreeItem> items = new List<TreeItem>();
        PopulateTreeItems(items, null, 1);
        return items;
    }

    void PopulateTreeItems(List<TreeItem> items, int? parentId, int level)
    {
        for (int i = 1; i <= ItemsPerLevel; i++)
        {
            var itemId = IdCounter++;
            items.Add(new TreeItem()
            {
                Id = itemId,
                Text = $"Level {level} Item {i} Id {itemId}",
                ParentId = parentId,
                HasChildren = level < TreeLevels,
                Tag = new TreeItem()

            });
            if (level < TreeLevels)
            {
                PopulateTreeItems(items, itemId, level + 1);
            }
        }
    }

    public class TreeItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? ParentId { get; set; }
        public bool HasChildren { get; set; }
        public object Tag { get; set; }

    }
}

