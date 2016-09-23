using DynamicDoc2.IService;
using System.Web.Mvc;

namespace DynamicDoc2.Controllers
{
    public class FieldController : DynamicDocumentController
    {
        IFieldService FieldService;

        public FieldController(IFieldService FieldService)
        {
            this.FieldService = FieldService;
        }

        public JsonResult GetAllFields()
        {
            return GetDynamicJson(new { AllFields = FieldService.GetallFields() });
        }

        public JsonResult CreateNewField(string fieldName, int fieldTypeId)
        {
            FieldService.CreateField(fieldName, fieldTypeId);
            return GetDynamicJson(true);
        }

        public JsonResult GetFieldById(int id)
        {
            return GetDynamicJson(FieldService.GetFieldById(id));
        }

        public JsonResult GetAllFieldsByName(string name)
        {
            return GetDynamicJson(new { AllFields = FieldService.GetAllFieldsByName(name) });
        }
    }
}