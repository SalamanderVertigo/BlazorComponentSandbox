using Microsoft.AspNetCore.Components;

namespace ComponentSandbox.Interfaces;

/*this will be referenced like:
     public IHeaderData? HeaderData { get; private set; }
     
     <div>
        @HeaderData?.ChildContent
    </div>
     
*/
public interface IHeaderData
{

    RenderFragment ChildContent { get; }
}