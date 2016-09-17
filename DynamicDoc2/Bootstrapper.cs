using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using DynamicDoc2.Service;
using DynamicDoc2.DataAccess;
using DynamicDoc2.IService;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
        var container = new UnityContainer();

        // Data Access Layer
        container.RegisterType<ILoginDataAccess, LoginDataAccess>();
        container.RegisterType<IUserDataAccess, UserDataAccess>();
        container.RegisterType<IFieldTypeDataAccess, FieldTypeDataAccess>();
        container.RegisterType<IFieldDataAccess, FieldDataAccess>();
        container.RegisterType<IDocumentDataAccess, DocumentDataAccess>();
        container.RegisterType<IDocumentFieldDataAccess, DocumentFieldDataAccess>();


        // Service Layer
        container.RegisterType<ILoginService, LoginService>();
        container.RegisterType<IUserService, UserService>();
        container.RegisterType<IFieldTypeService, FieldTypeService>();
        container.RegisterType<IFieldService, FieldService>();
        container.RegisterType<IDocumentService, DocumentService>();
        container.RegisterType<IDocumentFieldService, DocumentFieldService>();
        

        RegisterTypes(container);

        return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}