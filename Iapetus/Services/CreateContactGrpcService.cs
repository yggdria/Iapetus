using Grpc.Core;

namespace Iapetus.Services;

public class CreateContactGrpcService : CreateContactService.CreateContactServiceBase 
{

    public override Task<ContactReply> GetContact(
        ContactRequest request,
        ServerCallContext context)
    {
        return Task.FromResult(new ContactReply
        {
            Guid = request.Guid,
            Name = "Jesper",
            LastName = "Andersen"
        });
    }
}