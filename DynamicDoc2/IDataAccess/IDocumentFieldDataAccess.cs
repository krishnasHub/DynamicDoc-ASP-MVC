using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.IDataAccess
{
    public interface IDocumentFieldDataAccess
    {
        DocumentField GetDocumentFieldById(int id);

        List<DocumentField> GetAllDocumentFieldsByDocument(Document document);

        List<DocumentField> GetAllDocumentFieldsByField(Field field);

        List<DocumentField> GetAllDocumentFieldsByDocumentAndField(Document document, Field field);

        List<DocumentField> GetAllDocumentFields();

        void SaveDocumentField(DocumentField documentField);
    }
}
