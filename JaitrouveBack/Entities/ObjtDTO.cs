﻿

namespace JaitrouveBack.Entities
{

   

    
    public class ObjtDTO
    {
         
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public IFormFile? Image { get; set; }
        public string? ImageURL { get; set; }
        public string Title { get; set; }
        public string? Venue { get; set; }
        public string? Description { get; set; }
        public string PhoneNumber { get; set; }
        public string? Date { get; set; }
        public CategoryType Category { get; set; }
        public IsFoundType IsFounded { get; set; }
        public string? Donnation { get; set; }

  

    }
}
