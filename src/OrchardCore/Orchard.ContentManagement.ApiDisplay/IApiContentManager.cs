using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Orchard.ContentManagement;
using Orchard.DisplayManagement.ModelBinding;

namespace Orchard.JsonApi
{
    /// <summary>
    /// Describe services responsible for displaying a api item.
    /// </summary>
    public interface IApiContentManager
    {
        Task<ApiItem> BuildAsync(ContentItem content, IUrlHelper urlHelper, IUpdateModel updater);
        Task<ApiItem> UpdateAsync(ContentItem content, IUpdateModel updater);
    }
}