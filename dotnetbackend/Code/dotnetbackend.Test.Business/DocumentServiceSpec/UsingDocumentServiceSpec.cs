using NSubstitute;
using dotnetbackend.Test.Framework;
using dotnetbackend.Business.Services;
using dotnetbackend.Data.Interfaces;

namespace dotnetbackend.Test.Business.DocumentServiceSpec
{
    public abstract class UsingDocumentServiceSpec : SpecFor<DocumentService>
    {
        protected IDocumentRepository _documentRepository;

        public override void Context()
        {
            _documentRepository = Substitute.For<IDocumentRepository>();
            subject = new DocumentService(_documentRepository);

        }

    }
}
