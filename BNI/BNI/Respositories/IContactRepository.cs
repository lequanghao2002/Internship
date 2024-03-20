using BNI.Models.Domain;
using BNI.Models.DTO;

namespace BNI.Respositories
{
    public interface IContactRepository
    {
        List<ContactDTO> GetAll();
        ContactDTO GetById(int id);
        AddRequestContactDTO AddContact(AddRequestContactDTO contact);
        AddRequestContactDTO UpdateContact(int contactId, AddRequestContactDTO contact);
        Contact? DeleteContact(int contactId);
    }
}
