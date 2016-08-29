using DynamicDoc2.IService;
using System.Web.Mvc;

namespace DynamicDoc2.Controllers
{
    public class FieldTypeController : DynamicDocumentController
    {
        IFieldTypeService FieldTypeService;

        public FieldTypeController(IFieldTypeService FieldTypeService)
        {
            this.FieldTypeService = FieldTypeService;
        }

        public JsonResult GetAllFieldTypes()
        {
            var ft = FieldTypeService.GetAllFieldTypes();

            return GetDynamicJson(new { fieldTypes = ft });
        }
    }
}