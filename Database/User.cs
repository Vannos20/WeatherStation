namespace Database
{
    public class User
    {
        
        public int Id { get; init; } 
        public string Name { get; set; } 

        
        public User(string name, int id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
