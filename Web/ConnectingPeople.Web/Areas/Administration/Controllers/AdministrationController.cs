namespace ConnectingPeople.Web.Areas.Administration.Controllers
{
    using ConnectingPeople.Common;
    using ConnectingPeople.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
