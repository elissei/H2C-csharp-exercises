namespace exercise_125
{
  public class HealthStation
  {
    public int weighings { get; private set; }

    // Create a constructor here, if needed

    public int Weigh(Person person)
    {
      weighings++;
      return person.weight;
    }

    public void Feed(Person person)
    {
      person.weight++;
    }
  }
}