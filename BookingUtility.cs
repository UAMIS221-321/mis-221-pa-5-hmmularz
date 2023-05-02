namespace mis_221_pa_5_hmmularz
{
    public class BookingUtility
    {
         static private Bookings[] allBookings;

        static private int count; 

        static public void SetAllBookings(Bookings[] allBookings){
            BookingUtility.allBookings = allBookings;
        }

        static public Bookings[] GetAllBookings(){
                return BookingUtility.allBookings;
        }

     static public void SetCount(int count){
            BookingUtility.count = count;
        }

        static public int GetCount(){
                return  BookingUtility.count;
        }


        static public void IncCount(){
            BookingUtility.count++; 

        }

          static public void ReadInBookings(){ //stream reader 

        //open 
        StreamReader rdr = new StreamReader("Bookings.txt"); //used RDR instead of In.File 
        BookingUtility.SetCount(0);
        Bookings[] allBookings = new Bookings[100]; //reads in the first line 

        //process
       string line =  rdr.ReadLine(); 
        while( line != null){
            string [] temp = line.Split("#"); 
            allBookings [BookingUtility.GetCount()] = new Bookings(int.Parse(temp[0]), temp[1], temp[2], temp[3], int.Parse(temp[4]), temp[5], temp[6]);
            BookingUtility.IncCount(); 
            line =  rdr.ReadLine(); 

        }

        //close 
        rdr.Close();
        BookingUtility.allBookings = allBookings; 


        }

        static public void WriteOutBookings(){ 
            StreamWriter sw = new StreamWriter("Bookings.txt");
                for(int i = 0; i < BookingUtility.count; i++){
                sw.WriteLine(BookingUtility.allBookings[i].ToFile());

                }
        sw.Close(); 
        }
    static public void DisplayAllBookings(){
        for(int i= 0; i < BookingUtility.count; i++){
            Console.WriteLine($"{allBookings[i].GettrainerId()} {allBookings[i].GetcustomerName()} {allBookings[i].GetcustomerEmail()} {allBookings[i].GettrainingDate()} {allBookings[i].GettrainerId()} {allBookings[i].GettrainerName()} {allBookings[i].Getstatus()}");
        }
    }

    }
}