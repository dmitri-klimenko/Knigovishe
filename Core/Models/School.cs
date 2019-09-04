namespace Knigosha.Persistence
{
    public class School
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
    }
}