namespace Database
{
    public class Sensor
    {
        public int Id { get; init; }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime MeasurementDate { get; set; }
        
        
        public Sensor(int id, string type, string name)
        {
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.MeasurementDate = DateTime.Now; 
        }
    }
}
