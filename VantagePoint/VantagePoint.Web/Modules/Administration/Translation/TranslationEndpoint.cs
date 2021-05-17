using Microsoft.AspNetCore.Mvc;
using Serenity.Services;
using MyRepository = VantagePoint.Administration.Repositories.TranslationRepository;

namespace VantagePoint.Administration.Endpoints
{
    [Route("Services/Administration/Translation/[action]")]
    [ServiceAuthorize(PermissionKeys.Translation)]
    public class TranslationController : ServiceEndpoint
    {
        public ListResponse<TranslationItem> List(TranslationListRequest request)
        {
            return new MyRepository().List(request);
        }

        [HttpPost]
        public SaveResponse Update(TranslationUpdateRequest request)
        {
            return new MyRepository().Update(request);
        }
    }
}
