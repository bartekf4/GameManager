using System.Diagnostics.CodeAnalysis;

namespace GameManager.Data.Models;

public class CategoryClosure
{
    [NotNull] public Category Ancestor { get; set; }

    public int AncestorId { get; set; }


    [NotNull] public Category Descendant { get; set; }
    public int DescendantId { get; set; }

    public int? Depth { get; set; }
}