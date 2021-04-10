namespace gateway.Models
{
    public class TimerRequest
    {
       public long Length {get;set;} 
       public string Message {get;set;}
    }
    public class TimerResponse{
        public long TimeRemaining{get;set;}
        public string Message {get;set;}
    }
}