using RestWithAspNetUdemy.Model;

namespace RestWithAspNetUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncremetAndGet(),
                FirstName = "Filipe",
                LastName = "Silva",
                Address = "teste",
                Gender = "Male"
            };
        }

        public List<Person> GetAll()
        {
            List<Person> list = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                list.Add(person);
            }

            return list.ToList();
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncremetAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" +i,
                Address = "Some address" + i,
                Gender = "Male"
            };
        }

        private long IncremetAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
