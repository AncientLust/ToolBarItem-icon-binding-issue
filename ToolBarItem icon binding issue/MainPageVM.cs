

using CommunityToolkit.Mvvm.ComponentModel;

namespace ToolBarItem_icon_binding_issue;

public partial class MainPageVM : ObservableObject
{
    [ObservableProperty] private string filterStatusIcon = "filter";
}
