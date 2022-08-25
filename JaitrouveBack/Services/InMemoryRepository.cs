using JaitrouveBack.Entities;

namespace JaitrouveBack.Services
{
    public class InMemoryRepository : IRepository
    {
        //On declare de façon privée la list des objets trouvés, tjrs mettre le type avant la variable en C#

        private List<ObjLost> _objLost;
        public InMemoryRepository()
        {
            _objLost = new List<ObjLost>()
            {
                new ObjLost()
                { Id = 1,
                  FirstName= "Oro",
                  LastName= "Regis",
                  Date= 1245345345,
                  PhoneNumber= "0759169448",
                  Image= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBKEGmmEQ4WlpXIfdqhhaFbJER2pXMLOFU3A&usqp=CAU",
                  Title= "Carte CNI",
                  Venue= "Abidjan, Cocody-Angré",
                  Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus at mauris in orci pretium egestas. In mollis, augue eget facilisis imperdiet, ipsum sapien venenatis eros, non faucibus dolor erat ornare augue. Vestibulum sodales diam nec velit vestibulum, quis condimentum purus tempor. In molestie egestas leo, quis tincidunt erat tempus in.",
                  Category= "Pieces d'identification",
                  IsFounded= false,
                },

                new ObjLost()
                { Id = 2,
                  FirstName= "Kobri",
                  LastName= "Eli",
                  Date= 1245345345,
                  PhoneNumber= "025489554",
                  Image= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBKEGmmEQ4WlpXIfdqhhaFbJER2pXMLOFU3A&usqp=CAU",
                  Title= "Plaque d'immatriculation",
                  Venue= "Abidjan, Abobo",
                  Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus at mauris in orci pretium egestas. In mollis, augue eget facilisis imperdiet, ipsum sapien venenatis eros, non faucibus dolor erat ornare augue. Vestibulum sodales diam nec velit vestibulum, quis condimentum purus tempor. In molestie egestas leo, quis tincidunt erat tempus in.",
                  Category= "Pieces de véhicule",
                  IsFounded= false,
                },

                new ObjLost()
                { Id = 3,
                  FirstName= "Koffi",
                  LastName= "Delphin",
                  Date= 1245345345,
                  PhoneNumber= "2156332555",
                  Image= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBKEGmmEQ4WlpXIfdqhhaFbJER2pXMLOFU3A&usqp=CAU",
                  Title= "Porte-Feuille",
                  Venue= "Bouaké, Nimbo",
                  Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus at mauris in orci pretium egestas. In mollis, augue eget facilisis imperdiet, ipsum sapien venenatis eros, non faucibus dolor erat ornare augue. Vestibulum sodales diam nec velit vestibulum, quis condimentum purus tempor. In molestie egestas leo, quis tincidunt erat tempus in.",
                  Category= "Accessoires",
                  IsFounded= false,
                },

                new ObjLost()
                { Id = 4,
                  FirstName= "Beugré",
                  LastName= "Cédric",
                  Date= 1245345345,
                  PhoneNumber= "2154632128",
                  Image= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBKEGmmEQ4WlpXIfdqhhaFbJER2pXMLOFU3A&usqp=CAU",
                  Title= "Lunettes pharmaceutiques",
                  Venue= "Abidjan, Cocody-Angré",
                  Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus at mauris in orci pretium egestas. In mollis, augue eget facilisis imperdiet, ipsum sapien venenatis eros, non faucibus dolor erat ornare augue. Vestibulum sodales diam nec velit vestibulum, quis condimentum purus tempor. In molestie egestas leo, quis tincidunt erat tempus in.",
                  Category= "Accessoires",
                  IsFounded= false,
                },

                new ObjLost()
                { Id = 5,
                  FirstName= "Brindou",
                  LastName= "Junior",
                  Date= 1245345345,
                  PhoneNumber= "074859623",
                  Image= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBKEGmmEQ4WlpXIfdqhhaFbJER2pXMLOFU3A&usqp=CAU",
                  Title= "Téléphone portable",
                  Venue= "Abidjan, Riviera palmeraie",
                  Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus at mauris in orci pretium egestas. In mollis, augue eget facilisis imperdiet, ipsum sapien venenatis eros, non faucibus dolor erat ornare augue. Vestibulum sodales diam nec velit vestibulum, quis condimentum purus tempor. In molestie egestas leo, quis tincidunt erat tempus in.",
                  Category= "Appareils électroniques",
                  IsFounded= false,
                },
            };
        }
        //on crée la méthode pour afficher la liste des objets perdus
        //le nom de la methode est précédée du type qui sera retourné
        public List<ObjLost> GetAllObjLost()
        {
            return _objLost;
        }
        public ObjLost GetObjLostById(long Id)
        {
            return _objLost.FirstOrDefault(x => x.Id == Id);
        }
    }
}
