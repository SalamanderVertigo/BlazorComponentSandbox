using Microsoft.AspNetCore.Components;

namespace ComponentSandbox.Templates;

public class CardHeaderTemplate : ComponentBase
{
    [Parameter]
    public string? Data { get; set; }

    [Parameter] public RenderFragment<string>? ChildContent { get; set; } = default;
    
    protected override void OnInitialized()
    {
        
        base.OnInitialized();
    }
}