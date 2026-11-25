public interface IClock{

    DateTime Now {get; }
}

public class GreetingService{
    private readonly IClock clock; 

    public GreetingService(IClock clock){
        this.clock = clock;
    }

    public string GetGreeting(){
        int hour = clock.Now.Hour;

        if(hour < 12){
            return "Good morning!";
        } else if(hour < 18){
            return "Good afternoon!";
        } else {
            return "Good evening!";
        }
    }
}
//Have students write tests with Moq to verify the behavior of the GreetingService class based on different times of the day
