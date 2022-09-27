using NSubstitute;
using dotnetbackend.Test.Framework;
using dotnetbackend.Api.Controllers;
using dotnetbackend.Business.Interfaces;


namespace dotnetbackend.Test.Api.DocumentControllerSpec
{
    public abstract class UsingDocumentControllerSpec : SpecFor<DocumentController>
    {
        protected IDocumentService _documentService;

        public override void Context()
        {
            _documentService = Substitute.For<IDocumentService>();
            subject = new DocumentController(_documentService);

        }

    }
}
