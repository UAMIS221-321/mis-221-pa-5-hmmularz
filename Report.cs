namespace mis_221_pa_5_hmmularz
{
    public class Report
    {
        static public void IndividualCustomerSessions(){
            Console.WriteLine("What is the customer's email you are looking for?");
           string userInput = Console.ReadLine(); 
           Bookings[] bookings = new Bookings[100];
           StreamReader rdr = new StreamReader("bookings.txt"); 
           string line = rdr.ReadLine();
                for(int i = 0; i < bookings.Count(); i++ ){ //read through the booking array 
                    if(userInput == bookings.GetcustomerEmail()){ //if the email is the same as the one the user entered 
                        if(BookingUtility.Getstatus() == true){ //and if that status is true, meaning that the session has been completed 
                            System.Console.WriteLine($"{Bookings[i]GetsessionId()}");// write out the session ID for the session
                        }
                        
                    }
                    i++;
                }

        }

        static public void HistoricalCustomerSessions(){ 
            


        }

        static public void HistoricalRevenueReport(){
          
         
        }
    }
}