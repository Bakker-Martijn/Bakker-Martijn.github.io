using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Martijn_Bakker.Layout;

public partial class Header
{
    [Inject] private IJSRuntime JS { get; set; } = default!;

    public bool IsOpen { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
			await JS.InvokeVoidAsync("import", "../Layout/Header.razor.js");
	}
}
