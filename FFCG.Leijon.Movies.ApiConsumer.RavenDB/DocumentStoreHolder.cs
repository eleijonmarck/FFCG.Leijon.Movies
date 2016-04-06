using System;
using Raven.Client;
using Raven.Client.Document;

namespace FFCG.Leijon.Movies.ApiConsumer.RavenDB
{
    public class DocumentStoreHolder
    {
        private static Lazy<IDocumentStore> store = new Lazy<IDocumentStore>(CreateStore);

        public static IDocumentStore Store
        {
            get { return store.Value; }
        }

        private static IDocumentStore CreateStore()
        {
            IDocumentStore store = new DocumentStore()
            {
                Url = "http://localhost:8080",
                DefaultDatabase = "Movies"
            }.Initialize();

            return store;
        }
    }
}