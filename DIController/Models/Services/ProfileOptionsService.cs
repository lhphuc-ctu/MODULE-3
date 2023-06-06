namespace DIController.Models.Services
{
    public class ProfileOptionsService
    {
        public List<string> ListGenders() 
        {
            return new List<string>() { "Female", "Male" };
        }
        public List<State> ListStates() 
        {
            return new List<State>()
            {
                new State("Alabama","AL"),
                new State("Alaska","AK"),
                new State("Ohio","OH"),
            };
        }
        public List<string> ListColors() 
        {
            return new List<string>() { "Blue", "Green", "Red", "Yellow" };
        }
    }
}
