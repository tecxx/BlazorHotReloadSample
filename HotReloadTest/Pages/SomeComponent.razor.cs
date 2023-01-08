using Microsoft.AspNetCore.Components;

namespace HotReloadTest.Pages;

public partial class SomeComponent<TItem> : ComponentBase
{
    TItem? Entity;

    string data;

    void ShowEntityData()
    {
        data = Entity.Summary;
    }
}
