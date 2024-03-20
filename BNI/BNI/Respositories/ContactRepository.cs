using BNI.Data;
using BNI.Models.Domain;
using BNI.Models.DTO;

namespace BNI.Respositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _appDbContext;

        public ContactRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public AddRequestContactDTO AddContact(AddRequestContactDTO contact)
        {
            var platform = _appDbContext.Platform.FirstOrDefault(p => p.Platform_Id == contact.Platform_Id);
            if(platform != null)
            {
                var newContact = new Contact
                {
                    FullName = contact.FullName,
                    Email = contact.Email,
                    Phone = contact.Phone,
                    Position = contact.Position,
                    Job = contact.Job,
                    CompanyName = contact.CompanyName,
                    CompanyAddress = contact.CompanyAddress,
                    YearExperience = contact.YearExperience,
                    MemberOfCSJ = contact.MemberOfCSJ,
                    SupportInformation = contact.SupportInformation,
                    PlatformId = contact.Platform_Id,

                };
                _appDbContext.Contact.Add(newContact);
                 _appDbContext.SaveChangesAsync();
            }    
            return contact;
        }

        public Contact? DeleteContact(int contactId)
        {
            var contact = _appDbContext.Contact.Find(contactId);
            if (contact != null)
            {
                _appDbContext.Contact.Remove(contact);
                _appDbContext.SaveChanges();
            }
            return contact;
        }

        public List<ContactDTO> GetAll()
        {
            var GetAllContacts = _appDbContext.Contact.Select(c => new ContactDTO()
            {
                Id = c.Id,
                FullName = c.FullName,
                Email = c.Email,
                Phone = c.Phone,
                Position = c.Position,
                Job = c.Job,
                CompanyName = c.CompanyName,
                CompanyAddress = c.CompanyAddress,
                YearExperience = c.YearExperience,
                MemberOfCSJ = c.MemberOfCSJ,
                SupportInformation = c.SupportInformation,
                PlatformName = c.Platform.Name
            }).ToList();
            return GetAllContacts;
        }

        public ContactDTO GetById(int id)
        {
            var getContact = _appDbContext.Contact.Where(x => x.Id == id);
            var contactDTO = getContact.Select(c => new ContactDTO()
            {
                Id = c.Id,
                FullName = c.FullName,
                Email = c.Email,
                Phone = c.Phone,
                Position = c.Position,
                Job = c.Job,
                CompanyName = c.CompanyName,
                CompanyAddress = c.CompanyAddress,
                YearExperience = c.YearExperience,
                MemberOfCSJ = c.MemberOfCSJ,
                SupportInformation = c.SupportInformation,
                PlatformName = c.Platform.Name
            }).FirstOrDefault();
            return contactDTO;
        }

        public AddRequestContactDTO UpdateContact(int contactId, AddRequestContactDTO contact)
        {
            var contactToUpdate = _appDbContext.Contact.FirstOrDefault(x => x.Id == contactId);
            if (contactToUpdate != null)
            {
                contactToUpdate.FullName = contact.FullName;
                contactToUpdate.Email = contact.Email;
                contactToUpdate.Phone = contact.Phone;
                contactToUpdate.Position = contact.Position;
                contactToUpdate.Job = contact.Job;
                contactToUpdate.CompanyName = contact.CompanyName;
                contactToUpdate.CompanyAddress = contact.CompanyAddress;
                contactToUpdate.YearExperience = contact.YearExperience;
                contactToUpdate.MemberOfCSJ = contact.MemberOfCSJ;
                contactToUpdate.SupportInformation = contact.SupportInformation;
                contactToUpdate.PlatformId = contact.Platform_Id;
                 _appDbContext.SaveChangesAsync();
            }
            return contact;
        }
    }
}
