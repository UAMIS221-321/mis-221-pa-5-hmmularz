namespace mis_221_pa_5_hmmularz
{
    public class ListingUtility
    {
          static private Listing[] allListings;

        static private int count; 

        static public void SetAllListings(Listing[] allListings){
            ListingUtility.allListings = allListings;
        }

        static public Listing[] GetAllListings(){
                return ListingUtility.allListings;
        }

     static public void SetCount(int count){
            ListingUtility.count = count;
        }

        static public int GetCount(){
                return  ListingUtility.count;
        }


        static public void IncCount(){
            ListingUtility.count++; 

        }

        static public void ReadInListings(){ //stream reader 
    //open 
        StreamReader RDR = new StreamReader("listings.txt"); //used RDR instead of In.File 
       ListingUtility.count = 0; 
       Listing[] allListings = new Listing[100];

        //process
       string Line =  RDR.ReadLine(); 
        while( Line != null){
            string [] temp = Line.Split("#"); 
            allListings [ListingUtility.count] = new Listing(int.Parse(temp[0]), temp[1], temp[2], temp[3], int.Parse(temp[4]), bool.Parse(temp[5]), bool.Parse(temp[6]));
           ListingUtility.count++; 
            Line =  RDR.ReadLine(); 

        }

        //close 
        RDR.Close();
        ListingUtility.allListings = allListings; 


        }

        static public void WriteOutListings(){ //stream writer 
             StreamWriter SW = new StreamWriter("listings.txt");
                for(int i = 0; i < ListingUtility.count; i++){
                    SW.WriteLine(ListingUtility.allListings[i].ToFile());
                }

        }
        static public void DisplayAllListings(){
        for(int i= 0; i < ListingUtility.count; i++){
            Console.WriteLine($"{allListings[i].GetlistingId()} {allListings[i].GettrainerName()} {allListings[i].GetdateOfSession()} {allListings[i].GettimeOfSession()} {allListings[i].GetcostOfSession()} {allListings[i].Getstatus()} {allListings[i].Getdeleted()} ");
        }
    }

    }
}