using Modules.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CodingTest.Controllers
{
    public class EmailTemplatesController : ApiController
    {
        // GET: EmailTemplates
        public EmailTemplates Get()
        {
            try
            {
                //EmailTemplates templates = new EmailTemplates();
                //EmailTemplatePageCriteria criteria = new EmailTemplatePageCriteria();

                //criteria.Active = true;
                //criteria.EmailType = Modules.Config.EmailType.WelcomeEmail;
                //criteria.Page = 1;
                //criteria.PageSize = 10;
                //criteria.SortBy = Modules.Config.EmailSortBy.EmailLabelAscending;

                //templates.LoadCriteria(criteria);

                //var viewModel = EmailTemplates.GetAll(Modules.Config.EmailSortBy.FromAddressAscending, 1, 10, true, Modules.Config.EmailType.WelcomeEmail);
                var viewModel = EmailTemplates.AllTemplates;


                return viewModel;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
    }
}