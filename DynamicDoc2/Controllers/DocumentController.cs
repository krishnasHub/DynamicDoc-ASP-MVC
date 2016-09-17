using DynamicDoc2.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicDoc2.Controllers
{
    public class DocumentController : DynamicDocumentController
    {
        IDocumentService DocumentService;

        public DocumentController(IDocumentService DocumentService)
        {
            this.DocumentService = DocumentService;
        }

        public JsonResult GetAllDocuments()
        {
            return GetDynamicJson(new { AllDocuments = DocumentService.GetAllDocuments() });
        }

        public JsonResult CreateNewDocument(string documentName)
        {
            DocumentService.CreateDocument(documentName);
            return GetDynamicJson(true);
        }
    }
}