using System;
using System.Reflection;

namespace FFCG.Leijon.Movies.Webbb.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}