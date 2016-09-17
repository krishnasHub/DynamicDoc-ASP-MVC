using DynamicDoc2.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicDoc2.Controllers
{
    public class DocumentFieldController : DynamicDocumentController
    {
        IDocumentFieldService DocumentFieldService;

        public DocumentFieldController(IDocumentFieldService DocumentFieldService)
        {
            this.DocumentFieldService = DocumentFieldService;
        }

        public JsonResult GetAllDocumentFields()
        {
            return GetDynamicJson(new { AllDocumentFields = DocumentFieldService.GetAllDocumentFields() });
        }

        public JsonResult GetAllDocumentFieldsForDocument(int documentid)
        {
            return GetDynamicJson(new { AllDocumentFields = DocumentFieldService.GetAllDocumentFieldsByDocument(documentid) });
        }

        public JsonResult CreateDocumentField(int documentId, int fieldId)
        {
            DocumentFieldService.CreateDocumentField(documentId, fieldId);

            return GetDynamicJson(true);
        }
    }
}